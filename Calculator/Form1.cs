using Calculator.Classes;
using Calculator.Database;
using Calculator.style;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Math_Text = "";
        string Last_Equation_Result = "";
        string Last_Equation_Text = "";
        history database = new history();
        static string valid_input_data = "";
        public Form1()
        {
            InitializeComponent();
            new list_style().Set_histoey_headers(history_list);
            database.check_tables();
            show_history();
        }


        //validate key pressess
        private bool validate_key_pressed(char charecter)
        {
            return valid_input_data.Contains(charecter);
        }


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
        private bool Validation_Math_Text(string text)
        {
            if (this.Math_Text.Count() > 1)
            {
                if (!Validate_Parantesis(text))
                {
                    return false;
                }
            }
            return true;
        }

        //replace math string parantesis with result its equations
        private string Replace_parentesis_value(string text, int start, int count, string replacement)
        {
            return text.Substring(0, start) + replacement + text.Substring(start + count);
        }

        //main part of calculation
        private bool Main_Calculation_Part()
        {
            try
            {
                double result = 0;
                while (Find_Parantesis(this.Math_Text))
                {
                    Tuple<int, int> parantesis = Get_Parantesis_Data(this.Math_Text);
                    result = Calculate(this.Math_Text.Substring(parantesis.Item1 + 1, parantesis.Item2 - 1));
                    this.Math_Text = Replace_parentesis_value(this.Math_Text, parantesis.Item1, parantesis.Item2, result.ToString());
                }
                result = Calculate(this.Math_Text);
                MessageBox.Show(result.ToString(), "resut");
                this.Last_Equation_Result = result.ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
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

        //add number or operation charecters to math text
        private void Add_Text_To_Math_Text(char charecter)
        {
            bool error = false;
            if (this.Math_Text.Count() > 0)
            {
                if (!Validation_Math_Text(this.Math_Text + charecter))
                {
                    error = true;
                }
            }
            else if (!char.IsDigit(charecter))
            {
                error = true;
            }

            if (error)
            {
                MessageBox.Show("لطفا قوانین ریاضی را رعیات کنید", "خطا");
            }
            else
            {
                this.Math_Text += charecter;
                tb_result.Text = this.Math_Text;
            }
        }

        //show history
        private void show_history()
        {
            List<Equation> data = database.GetHistory();
            history_list.Rows.Clear();
            foreach (Equation item in data)
            {
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(history_list);
                row.Cells[0].Value = item.id;
                row.Cells[1].Value = item.equation;
                row.Cells[2].Value = item.result;
                rows.Add(row);
                history_list.Rows.AddRange(rows.ToArray());
                history_list.ClearSelection();
            }
        }

        //clear text box and math text variable
        private void clear_math_text()
        {
            this.Math_Text = "";
            tb_result.Text = "";
        }

        //calculate key
        private void button2_Click(object sender, EventArgs e)
        {
            Last_Equation_Text = this.Math_Text;
            bool result = Main_Calculation_Part();
            if (result)
            {
                database.insert_to_history(Last_Equation_Text, Last_Equation_Result);
            }
            show_history();
            clear_math_text();
        }
        //show result in text box
        private void show_result()
        {
            tb_result.Text = this.Last_Equation_Result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Text_To_Math_Text('/');
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('*');
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('%');
        }

        private void button11_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('-');
        }

        private void button15_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('7');
        }

        private void button16_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('8');
        }

        private void button17_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('9');
        }

        private void button18_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('+');
        }

        private void button22_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('4');
        }

        private void button23_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('5');
        }

        private void button24_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('6');
        }

        private void button29_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('1');
        }

        private void button30_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('2');
        }

        private void button31_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('3');
        }

        private void button36_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('0');
        }

        private void button37_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('.');
        }

        private void button38_Click(object sender, EventArgs e)
        {

            Add_Text_To_Math_Text('^');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            clear_math_text();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            database.delete_history();
            clear_math_text();
            show_history();
        }


        private void tb_result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validate_key_pressed(e.KeyChar))
            {
                Add_Text_To_Math_Text(e.KeyChar);
            }
            else
            {
                MessageBox.Show("لطفا کاراکتر ریاضی وارد کنید", "خطا");
                tb_result.Text = tb_result.Text.Substring(0, tb_result.Text.Count());
                tb_result.Refresh();
            }
        }
    }
}
