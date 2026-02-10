namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            tb_result = new TextBox();
            history_list = new DataGridView();
            button36 = new Button();
            button37 = new Button();
            button38 = new Button();
            button2 = new Button();
            button32 = new Button();
            button31 = new Button();
            button30 = new Button();
            button29 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button1 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)history_list).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(tb_result, 0, 0);
            tableLayoutPanel1.Controls.Add(history_list, 4, 0);
            tableLayoutPanel1.Controls.Add(button36, 0, 6);
            tableLayoutPanel1.Controls.Add(button37, 1, 6);
            tableLayoutPanel1.Controls.Add(button38, 2, 6);
            tableLayoutPanel1.Controls.Add(button2, 3, 6);
            tableLayoutPanel1.Controls.Add(button32, 3, 5);
            tableLayoutPanel1.Controls.Add(button31, 2, 5);
            tableLayoutPanel1.Controls.Add(button30, 1, 5);
            tableLayoutPanel1.Controls.Add(button29, 0, 5);
            tableLayoutPanel1.Controls.Add(button22, 0, 4);
            tableLayoutPanel1.Controls.Add(button23, 1, 4);
            tableLayoutPanel1.Controls.Add(button24, 2, 4);
            tableLayoutPanel1.Controls.Add(button25, 3, 4);
            tableLayoutPanel1.Controls.Add(button15, 0, 3);
            tableLayoutPanel1.Controls.Add(button16, 1, 3);
            tableLayoutPanel1.Controls.Add(button17, 2, 3);
            tableLayoutPanel1.Controls.Add(button18, 3, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Controls.Add(button9, 1, 2);
            tableLayoutPanel1.Controls.Add(button10, 2, 2);
            tableLayoutPanel1.Controls.Add(button11, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(521, 417);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(89, 62);
            button4.Name = "button4";
            button4.Size = new Size(80, 53);
            button4.TabIndex = 47;
            button4.Text = ")";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(3, 62);
            button3.Name = "button3";
            button3.Size = new Size(80, 53);
            button3.TabIndex = 46;
            button3.Text = "(";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tb_result
            // 
            tableLayoutPanel1.SetColumnSpan(tb_result, 4);
            tb_result.Dock = DockStyle.Fill;
            tb_result.Location = new Point(3, 20);
            tb_result.Margin = new Padding(3, 20, 3, 3);
            tb_result.Name = "tb_result";
            tb_result.Size = new Size(338, 23);
            tb_result.TabIndex = 42;
            tb_result.KeyPress += tb_result_KeyPress;
            // 
            // history_list
            // 
            history_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(history_list, 2);
            history_list.Dock = DockStyle.Fill;
            history_list.Location = new Point(347, 3);
            history_list.MultiSelect = false;
            history_list.Name = "history_list";
            tableLayoutPanel1.SetRowSpan(history_list, 7);
            history_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            history_list.Size = new Size(171, 411);
            history_list.TabIndex = 45;
            // 
            // button36
            // 
            button36.Dock = DockStyle.Fill;
            button36.Location = new Point(3, 357);
            button36.Name = "button36";
            button36.Size = new Size(80, 57);
            button36.TabIndex = 35;
            button36.Text = "0";
            button36.UseVisualStyleBackColor = true;
            button36.Click += button36_Click;
            // 
            // button37
            // 
            button37.Dock = DockStyle.Fill;
            button37.Location = new Point(89, 357);
            button37.Name = "button37";
            button37.Size = new Size(80, 57);
            button37.TabIndex = 36;
            button37.Text = ".";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button37_Click;
            // 
            // button38
            // 
            button38.Dock = DockStyle.Fill;
            button38.Location = new Point(175, 357);
            button38.Name = "button38";
            button38.Size = new Size(80, 57);
            button38.TabIndex = 37;
            button38.Text = "^";
            button38.UseVisualStyleBackColor = true;
            button38.Click += button38_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(261, 357);
            button2.Name = "button2";
            button2.Size = new Size(80, 57);
            button2.TabIndex = 44;
            button2.Text = "=";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button32
            // 
            button32.Dock = DockStyle.Fill;
            button32.Location = new Point(261, 298);
            button32.Name = "button32";
            button32.Size = new Size(80, 53);
            button32.TabIndex = 31;
            button32.Text = "Ac";
            button32.UseVisualStyleBackColor = true;
            button32.Click += button32_Click;
            // 
            // button31
            // 
            button31.Dock = DockStyle.Fill;
            button31.Location = new Point(175, 298);
            button31.Name = "button31";
            button31.Size = new Size(80, 53);
            button31.TabIndex = 30;
            button31.Text = "3";
            button31.UseVisualStyleBackColor = true;
            button31.Click += button31_Click;
            // 
            // button30
            // 
            button30.Dock = DockStyle.Fill;
            button30.Location = new Point(89, 298);
            button30.Name = "button30";
            button30.Size = new Size(80, 53);
            button30.TabIndex = 29;
            button30.Text = "2";
            button30.UseVisualStyleBackColor = true;
            button30.Click += button30_Click;
            // 
            // button29
            // 
            button29.Dock = DockStyle.Fill;
            button29.Location = new Point(3, 298);
            button29.Name = "button29";
            button29.Size = new Size(80, 53);
            button29.TabIndex = 28;
            button29.Text = "1";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button29_Click;
            // 
            // button22
            // 
            button22.Dock = DockStyle.Fill;
            button22.Location = new Point(3, 239);
            button22.Name = "button22";
            button22.Size = new Size(80, 53);
            button22.TabIndex = 21;
            button22.Text = "4";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // button23
            // 
            button23.Dock = DockStyle.Fill;
            button23.Location = new Point(89, 239);
            button23.Name = "button23";
            button23.Size = new Size(80, 53);
            button23.TabIndex = 22;
            button23.Text = "5";
            button23.UseVisualStyleBackColor = true;
            button23.Click += button23_Click;
            // 
            // button24
            // 
            button24.Dock = DockStyle.Fill;
            button24.Location = new Point(175, 239);
            button24.Name = "button24";
            button24.Size = new Size(80, 53);
            button24.TabIndex = 23;
            button24.Text = "6";
            button24.UseVisualStyleBackColor = true;
            button24.Click += button24_Click;
            // 
            // button25
            // 
            button25.Dock = DockStyle.Fill;
            button25.Location = new Point(261, 239);
            button25.Name = "button25";
            button25.Size = new Size(80, 53);
            button25.TabIndex = 24;
            button25.Text = "C";
            button25.UseVisualStyleBackColor = true;
            button25.Click += button25_Click;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(3, 180);
            button15.Name = "button15";
            button15.Size = new Size(80, 53);
            button15.TabIndex = 14;
            button15.Text = "7";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(89, 180);
            button16.Name = "button16";
            button16.Size = new Size(80, 53);
            button16.TabIndex = 15;
            button16.Text = "8";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Dock = DockStyle.Fill;
            button17.Location = new Point(175, 180);
            button17.Name = "button17";
            button17.Size = new Size(80, 53);
            button17.TabIndex = 16;
            button17.Text = "9";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Dock = DockStyle.Fill;
            button18.Location = new Point(261, 180);
            button18.Name = "button18";
            button18.Size = new Size(80, 53);
            button18.TabIndex = 17;
            button18.Text = "+";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 121);
            button1.Name = "button1";
            button1.Size = new Size(80, 53);
            button1.TabIndex = 0;
            button1.Text = "/";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(89, 121);
            button9.Name = "button9";
            button9.Size = new Size(80, 53);
            button9.TabIndex = 8;
            button9.Text = "*";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(175, 121);
            button10.Name = "button10";
            button10.Size = new Size(80, 53);
            button10.TabIndex = 9;
            button10.Text = "%";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(261, 121);
            button11.Name = "button11";
            button11.Size = new Size(80, 53);
            button11.TabIndex = 10;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 417);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ماشین حساب";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)history_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button1;
        private TextBox tb_result;
        private Button button38;
        private Button button37;
        private Button button36;
        private Button button2;
        private DataGridView history_list;
        private Button button4;
        private Button button3;
    }
}
