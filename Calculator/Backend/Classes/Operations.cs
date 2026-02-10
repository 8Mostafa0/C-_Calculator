namespace Calculator.Backend
{
    public class Operations_Class
    {

        // check charecter is number or math operation charecter
        private bool Is_Number(char charecter)
        {
            if (charecter == '.')
            {
                return true;
            }
            return char.IsLetterOrDigit(charecter);
        }

        // do math of two numbers based on the opration
        private double Do_Operation(double number_1, double number_2, char operation)
        {
            switch (operation)
            {
                case '+': { return number_1 + number_2; }
                case '-': { return number_1 - number_2; }
                case '/': { return number_1 / number_2; }
                case '*': { return number_1 * number_2; }
                case '^': { return Math.Pow(number_1, number_2); }
                case '%': { return (number_1 / number_2) * 100; }
                default: { return number_1; }
            }
        }


        //do validation check on math text to find out problems
        public bool Validation_Math_Text(string text)
        {
            if (text.Count() > 1)
            {
                if (!Validate_Parantesis(text))
                {
                    return false;
                }
            }
            return true;
        }

        //replace math string parantesis with result its equations
        private string Replace_parentesis_value(string text, int start, int count, string? replacement)
        {
            return text.Substring(0, start) + replacement + text.Substring(start + count);
        }

        //main part of calculation
        public double? Main_Calculation_Part(string text)
        {
            double? result = null;
            try
            {
                while (Find_Parantesis(text))
                {
                    Tuple<int, int> parantesis = Get_Parantesis_Data(text);
                    result = Calculate(text.Substring(parantesis.Item1 + 1, parantesis.Item2 - 1));
                    text = Replace_parentesis_value(text, parantesis.Item1, parantesis.Item2, result.ToString());
                }
                result = Calculate(text);
                MessageBox.Show(result.ToString(), "resut");
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //start calculation based on orders
        private double Calculate(string text)
        {
            double result = 0;
            char last_operation = '+';
            string first_number = "";
            bool first_number_filled = false;
            string second_number = "";
            int index = 0;
            foreach (char item in text)
            {
                if (!first_number_filled)
                {
                    if (Is_Number(item))
                    {
                        first_number += item;
                    }
                    else
                    {
                        first_number_filled = true;
                        last_operation = item;
                    }
                }
                else
                {
                    if (Is_Number(item))
                    {
                        second_number += item;
                    }
                    else
                    {
                        first_number = Do_Operation(Convert.ToDouble(first_number), Convert.ToDouble(second_number), last_operation).ToString();
                        second_number = "";
                    }
                }
                index++;
            }
            if (index == text.Count())
            {
                result = Do_Operation(Convert.ToDouble(first_number), Convert.ToDouble(second_number), last_operation);
            }
            return result;
        }


        //check ther is parantesis in the text or not
        private bool Find_Parantesis(string Text)
        {
            if (Text.Contains('(') && Text.Contains(')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //find start index of parantesis and len of it
        private Tuple<int, int> Get_Parantesis_Data(string Text)
        {
            int index = 0;
            int index_start = 0;
            int len = 0;
            foreach (char item in Text)
            {
                if (item == '(')
                {
                    index_start = index;
                }
                else if (item == ')')
                {
                    len = index - index_start;
                    break;
                }
                index++;
            }
            return Tuple.Create(index_start, len + 1);
        }

        //validate if parantesis exist the count of opens are equal to closed one or not
        private bool Validate_Parantesis(string Text)
        {
            if (Text.Count(l => l == '(') == Text.Count(l => l == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
