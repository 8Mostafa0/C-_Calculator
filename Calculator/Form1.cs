using Calculator.Backend;
using Calculator.Backend.Classes;
using Calculator.Backend.Database;
using Calculator.Backend.style;
namespace Calculator
{
    public partial class Form1 : Form
    {
        string Math_Text = "";
        string Last_Equation_Result = "";
        string Last_Equation_Text = "";
        static string valid_input_data = "";
        History database = new History();
        Operations_Class Operation = new Operations_Class();
        
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


        //add number or operation charecters to math text
        private void Add_Text_To_Math_Text(char charecter)
        {
            bool error = false;
            if (this.Math_Text.Count() > 0)
            {
                if (!Operation.Validation_Math_Text(this.Math_Text + charecter))
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
            double? result = Operation.Main_Calculation_Part(this.Math_Text);
            if (result!= null)
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
