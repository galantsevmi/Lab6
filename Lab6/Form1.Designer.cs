namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.equals = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.Button();
            this.digit_null = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.digit_three = new System.Windows.Forms.Button();
            this.digit_two = new System.Windows.Forms.Button();
            this.digit_one = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.digit_six = new System.Windows.Forms.Button();
            this.digit_five = new System.Windows.Forms.Button();
            this.digit_four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.digit_nine = new System.Windows.Forms.Button();
            this.digit_eight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.erase = new System.Windows.Forms.Button();
            this.sign_of_number = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.digit_seven = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equals
            // 
            this.equals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equals.Location = new System.Drawing.Point(3, 283);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(78, 67);
            this.equals.TabIndex = 0;
            this.equals.TabStop = false;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(9, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(339, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CE
            // 
            this.CE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CE.Location = new System.Drawing.Point(3, 213);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(78, 64);
            this.CE.TabIndex = 2;
            this.CE.TabStop = false;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // digit_null
            // 
            this.digit_null.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_null.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_null.Location = new System.Drawing.Point(87, 213);
            this.digit_null.Name = "digit_null";
            this.digit_null.Size = new System.Drawing.Size(78, 64);
            this.digit_null.TabIndex = 3;
            this.digit_null.TabStop = false;
            this.digit_null.Text = "0";
            this.digit_null.UseVisualStyleBackColor = true;
            this.digit_null.Click += new System.EventHandler(this.digit_null_Click);
            // 
            // dot
            // 
            this.dot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(171, 213);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(78, 64);
            this.dot.TabIndex = 4;
            this.dot.TabStop = false;
            this.dot.Text = ",";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // divide
            // 
            this.divide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.Location = new System.Drawing.Point(255, 213);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(81, 64);
            this.divide.TabIndex = 5;
            this.divide.TabStop = false;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiply.Location = new System.Drawing.Point(255, 143);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(81, 64);
            this.multiply.TabIndex = 9;
            this.multiply.TabStop = false;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // digit_three
            // 
            this.digit_three.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_three.Location = new System.Drawing.Point(171, 143);
            this.digit_three.Name = "digit_three";
            this.digit_three.Size = new System.Drawing.Size(78, 64);
            this.digit_three.TabIndex = 8;
            this.digit_three.TabStop = false;
            this.digit_three.Text = "3";
            this.digit_three.UseVisualStyleBackColor = true;
            this.digit_three.Click += new System.EventHandler(this.digit_three_Click);
            // 
            // digit_two
            // 
            this.digit_two.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_two.Location = new System.Drawing.Point(87, 143);
            this.digit_two.Name = "digit_two";
            this.digit_two.Size = new System.Drawing.Size(78, 64);
            this.digit_two.TabIndex = 7;
            this.digit_two.TabStop = false;
            this.digit_two.Text = "2";
            this.digit_two.UseVisualStyleBackColor = true;
            this.digit_two.Click += new System.EventHandler(this.digit_two_Click);
            // 
            // digit_one
            // 
            this.digit_one.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_one.Location = new System.Drawing.Point(3, 143);
            this.digit_one.Name = "digit_one";
            this.digit_one.Size = new System.Drawing.Size(78, 64);
            this.digit_one.TabIndex = 6;
            this.digit_one.TabStop = false;
            this.digit_one.Text = "1";
            this.digit_one.UseVisualStyleBackColor = true;
            this.digit_one.Click += new System.EventHandler(this.digit_one_Click);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(255, 73);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(81, 64);
            this.minus.TabIndex = 13;
            this.minus.TabStop = false;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // digit_six
            // 
            this.digit_six.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_six.Location = new System.Drawing.Point(171, 73);
            this.digit_six.Name = "digit_six";
            this.digit_six.Size = new System.Drawing.Size(78, 64);
            this.digit_six.TabIndex = 12;
            this.digit_six.TabStop = false;
            this.digit_six.Text = "6";
            this.digit_six.UseVisualStyleBackColor = true;
            this.digit_six.Click += new System.EventHandler(this.digit_six_Click);
            // 
            // digit_five
            // 
            this.digit_five.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_five.Location = new System.Drawing.Point(87, 73);
            this.digit_five.Name = "digit_five";
            this.digit_five.Size = new System.Drawing.Size(78, 64);
            this.digit_five.TabIndex = 11;
            this.digit_five.TabStop = false;
            this.digit_five.Text = "5";
            this.digit_five.UseVisualStyleBackColor = true;
            this.digit_five.Click += new System.EventHandler(this.digit_five_Click);
            // 
            // digit_four
            // 
            this.digit_four.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_four.Location = new System.Drawing.Point(3, 73);
            this.digit_four.Name = "digit_four";
            this.digit_four.Size = new System.Drawing.Size(78, 64);
            this.digit_four.TabIndex = 10;
            this.digit_four.TabStop = false;
            this.digit_four.Text = "4";
            this.digit_four.UseVisualStyleBackColor = true;
            this.digit_four.Click += new System.EventHandler(this.digit_four_Click);
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(255, 3);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(81, 64);
            this.plus.TabIndex = 17;
            this.plus.TabStop = false;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // digit_nine
            // 
            this.digit_nine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_nine.Location = new System.Drawing.Point(171, 3);
            this.digit_nine.Name = "digit_nine";
            this.digit_nine.Size = new System.Drawing.Size(78, 64);
            this.digit_nine.TabIndex = 16;
            this.digit_nine.TabStop = false;
            this.digit_nine.Text = "9";
            this.digit_nine.UseVisualStyleBackColor = true;
            this.digit_nine.Click += new System.EventHandler(this.digit_nine_Click);
            // 
            // digit_eight
            // 
            this.digit_eight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_eight.Location = new System.Drawing.Point(87, 3);
            this.digit_eight.Name = "digit_eight";
            this.digit_eight.Size = new System.Drawing.Size(78, 64);
            this.digit_eight.TabIndex = 15;
            this.digit_eight.TabStop = false;
            this.digit_eight.Text = "8";
            this.digit_eight.UseVisualStyleBackColor = true;
            this.digit_eight.Click += new System.EventHandler(this.digit_eight_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 25);
            this.label1.TabIndex = 18;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // erase
            // 
            this.erase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.erase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.erase.Location = new System.Drawing.Point(255, 283);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(81, 67);
            this.erase.TabIndex = 20;
            this.erase.TabStop = false;
            this.erase.Text = "<--";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.erase_Click);
            // 
            // sign_of_number
            // 
            this.sign_of_number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_of_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_of_number.Location = new System.Drawing.Point(171, 283);
            this.sign_of_number.Name = "sign_of_number";
            this.sign_of_number.Size = new System.Drawing.Size(78, 67);
            this.sign_of_number.TabIndex = 19;
            this.sign_of_number.TabStop = false;
            this.sign_of_number.Text = "+/-";
            this.sign_of_number.UseVisualStyleBackColor = true;
            this.sign_of_number.Click += new System.EventHandler(this.sign_of_number_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.digit_seven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.erase, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.digit_four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sign_of_number, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiply, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.digit_three, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.digit_one, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.digit_six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.digit_nine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.digit_five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.digit_two, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CE, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.digit_null, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.equals, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.digit_eight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dot, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 353);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // digit_seven
            // 
            this.digit_seven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digit_seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit_seven.Location = new System.Drawing.Point(3, 3);
            this.digit_seven.Name = "digit_seven";
            this.digit_seven.Size = new System.Drawing.Size(78, 64);
            this.digit_seven.TabIndex = 21;
            this.digit_seven.TabStop = false;
            this.digit_seven.Text = "7";
            this.digit_seven.UseVisualStyleBackColor = true;
            this.digit_seven.Click += new System.EventHandler(this.digit_seven_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button digit_null;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button digit_three;
        private System.Windows.Forms.Button digit_two;
        private System.Windows.Forms.Button digit_one;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button digit_six;
        private System.Windows.Forms.Button digit_five;
        private System.Windows.Forms.Button digit_four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button digit_nine;
        private System.Windows.Forms.Button digit_eight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.Button sign_of_number;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button digit_seven;
    }
}

