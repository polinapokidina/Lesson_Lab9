namespace Lesson_Lab9
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.txtKolvo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtSymbols = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKolvoSymbols = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите строку";
            // 
            // txtString
            // 
            this.txtString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtString.Location = new System.Drawing.Point(173, 32);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 1;
            // 
            // txtKolvo
            // 
            this.txtKolvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKolvo.Location = new System.Drawing.Point(173, 79);
            this.txtKolvo.Name = "txtKolvo";
            this.txtKolvo.Size = new System.Drawing.Size(47, 20);
            this.txtKolvo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество символов \"а\"";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(249, 173);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Подсчитать";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtSymbols
            // 
            this.txtSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSymbols.Location = new System.Drawing.Point(173, 118);
            this.txtSymbols.Name = "txtSymbols";
            this.txtSymbols.Size = new System.Drawing.Size(100, 20);
            this.txtSymbols.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Символ(ы) вхождений";
            // 
            // txtKolvoSymbols
            // 
            this.txtKolvoSymbols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKolvoSymbols.Location = new System.Drawing.Point(173, 154);
            this.txtKolvoSymbols.Name = "txtKolvoSymbols";
            this.txtKolvoSymbols.Size = new System.Drawing.Size(47, 20);
            this.txtKolvoSymbols.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Количество символов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 208);
            this.Controls.Add(this.txtKolvoSymbols);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymbols);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtKolvo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.TextBox txtKolvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtSymbols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKolvoSymbols;
        private System.Windows.Forms.Label label4;
    }
}

