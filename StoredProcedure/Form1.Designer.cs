namespace StoredProcedure
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

        private Button GetButton1()
        {
            return button1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button button1)
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(339, 3);
            label1.Name = "label1";
            label1.Size = new Size(230, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Details Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 41);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Employee ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(46, 77);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(46, 125);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Employee City";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 171);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 4;
            label5.Text = "Employee Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(46, 213);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 5;
            label6.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(46, 262);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 6;
            label7.Text = "Joining Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(259, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(259, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(259, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 307);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(259, 27);
            textBox4.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 28);
            comboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(184, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(46, 314);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 13;
            label8.Text = "Contact";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(184, 211);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(314, 211);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(80, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(488, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(691, 287);
            dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(75, 376);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "insert";
            button1.UseVisualStyleBackColor = true;
           // button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 376);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 18;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(349, 376);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(1233, 507);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}