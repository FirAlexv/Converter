
namespace Converter
{
    partial class ConverterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Binary = new System.Windows.Forms.TextBox();
            this.textBox_Ternary = new System.Windows.Forms.TextBox();
            this.textBox_Octal = new System.Windows.Forms.TextBox();
            this.textBox_Decimal = new System.Windows.Forms.TextBox();
            this.textBox_Hexadecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Двоичная сис";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Троичная сис";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Восьмиричная сис";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Десятиричная сис";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Шеснадцатиричная сис";
            // 
            // textBox_Binary
            // 
            this.textBox_Binary.Enabled = false;
            this.textBox_Binary.Location = new System.Drawing.Point(189, 67);
            this.textBox_Binary.Name = "textBox_Binary";
            this.textBox_Binary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Binary.TabIndex = 5;
            // 
            // textBox_Ternary
            // 
            this.textBox_Ternary.Enabled = false;
            this.textBox_Ternary.Location = new System.Drawing.Point(189, 115);
            this.textBox_Ternary.Name = "textBox_Ternary";
            this.textBox_Ternary.Size = new System.Drawing.Size(100, 20);
            this.textBox_Ternary.TabIndex = 6;
            // 
            // textBox_Octal
            // 
            this.textBox_Octal.Enabled = false;
            this.textBox_Octal.Location = new System.Drawing.Point(189, 160);
            this.textBox_Octal.Name = "textBox_Octal";
            this.textBox_Octal.Size = new System.Drawing.Size(100, 20);
            this.textBox_Octal.TabIndex = 7;
            // 
            // textBox_Decimal
            // 
            this.textBox_Decimal.Location = new System.Drawing.Point(189, 23);
            this.textBox_Decimal.Name = "textBox_Decimal";
            this.textBox_Decimal.Size = new System.Drawing.Size(100, 20);
            this.textBox_Decimal.TabIndex = 8;
            this.textBox_Decimal.TextChanged += new System.EventHandler(this.TextBox_Decimal_TextChanged);
            // 
            // textBox_Hexadecimal
            // 
            this.textBox_Hexadecimal.Enabled = false;
            this.textBox_Hexadecimal.Location = new System.Drawing.Point(189, 203);
            this.textBox_Hexadecimal.Name = "textBox_Hexadecimal";
            this.textBox_Hexadecimal.Size = new System.Drawing.Size(100, 20);
            this.textBox_Hexadecimal.TabIndex = 9;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 240);
            this.Controls.Add(this.textBox_Hexadecimal);
            this.Controls.Add(this.textBox_Decimal);
            this.Controls.Add(this.textBox_Octal);
            this.Controls.Add(this.textBox_Ternary);
            this.Controls.Add(this.textBox_Binary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Converter";
            this.Text = "Конвертер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Binary;
        private System.Windows.Forms.TextBox textBox_Ternary;
        private System.Windows.Forms.TextBox textBox_Octal;
        private System.Windows.Forms.TextBox textBox_Decimal;
        private System.Windows.Forms.TextBox textBox_Hexadecimal;
    }
}

