using Calculator.Backend.Classes;

namespace Calculator.Backend
{
    public class Operations_Class
    {
        string valid_numbers = "1234567890)(";
        string valid_charecters = ".+-*/^%";

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
        public bool Validation_Math_Text(string equation, char new_charecter)
        {
            if (equation.Length == 0)
            {
                if (valid_numbers.Contains(new_charecter))
                {
                    return true;
                }
                else if (valid_charecters.Contains(new_charecter))
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (valid_charecters.Contains(equation[^1]) && valid_charecters.Contains(new_charecter))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
        //check any operator left in the equation or not
        private bool operations_exist_in_equations_text(string text)
        {
            foreach (char c in valid_charecters)
            {
                if (text.Contains(c))
                {
                    return true;
                }
            }
            return false;
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
                    result = Calculate(text.Substring(parantesis.Item1 + 1, parantesis.Item2 - 2));
                    text = Replace_parentesis_value(text, parantesis.Item1, parantesis.Item2, result.ToString());
                }
                result = Calculate(text);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }


        private List<Equation_Order> Sort_all_Numbers(string text)
        {
            List<Equation_Order> numbers = new List<Equation_Order>();
            string num1 = "";
            Equation_Order equation = new Equation_Order();
            double last_number = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]) || text[i] == '.')
                {
                    num1 += text[i];
                }
                else
                {
                    if (numbers.Count() > 0)
                    {
                        if(equation.Second_Value == null)
                        {
                            equation.First_Value = last_number;
                            equation.Second_Value = double.Parse(num1);
                        }
                    }
                    else
                    {
                        if (equation.First_Value == null)
                        {
                            equation.First_Value = double.Parse(num1);
                        }
                        else if (equation.Second_Value == null)
                        {
                            equation.Second_Value = double.Parse(num1);
                        }
                        equation.Operator = text[i];
                        if (equation.First_Value != null && equation.Second_Value != null)
                        {
                            last_number = equation.Second_Value;
                            numbers.Add(equation);
                            equation = new Equation_Order();
                        }

                    }
                }
            }
            return numbers;
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
            if (operations_exist_in_equations_text(text))
            {//TODO:// 
            }
            else
            {
                result = double.Parse(text);
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
            int index_start = 0;
            int index_end = 0;
            int len = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == ')')
                {
                    index_end = i;
                    break;
                }
            }
            for (int i = index_end; i > 0; i--)
            {
                if (Text[i] == '(')
                {
                    index_start = i;
                    break;
                }
            }
            len = index_end - index_start;
            return Tuple.Create(index_start, len + 1);
        }

        //validate if parantesis exist the count of opens are equal to closed one or not
        public bool Validate_Parantesis(string Text)
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
