namespace VTcodes
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GenCode = new System.Windows.Forms.Button();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fix = new System.Windows.Forms.Button();
            this.textBoxFixed = new System.Windows.Forms.TextBox();
            this.textBoxTypeError = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GenCode
            // 
            this.GenCode.Location = new System.Drawing.Point(12, 51);
            this.GenCode.Name = "GenCode";
            this.GenCode.Size = new System.Drawing.Size(130, 23);
            this.GenCode.TabIndex = 0;
            this.GenCode.Text = "Генерация слова";
            this.GenCode.UseVisualStyleBackColor = true;
            this.GenCode.Click += new System.EventHandler(this.GenCode_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(12, 26);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(29, 19);
            this.textBoxN.TabIndex = 1;
            this.textBoxN.Text = "7";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(12, 120);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(130, 19);
            this.textBoxCode.TabIndex = 2;
            this.textBoxCode.Text = "00110100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // Fix
            // 
            this.Fix.Location = new System.Drawing.Point(12, 145);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(130, 22);
            this.Fix.TabIndex = 5;
            this.Fix.Text = "Исправить";
            this.Fix.UseVisualStyleBackColor = true;
            this.Fix.Click += new System.EventHandler(this.Fix_Click);
            // 
            // textBoxFixed
            // 
            this.textBoxFixed.Location = new System.Drawing.Point(192, 23);
            this.textBoxFixed.Multiline = true;
            this.textBoxFixed.Name = "textBoxFixed";
            this.textBoxFixed.Size = new System.Drawing.Size(130, 144);
            this.textBoxFixed.TabIndex = 6;
            // 
            // textBoxTypeError
            // 
            this.textBoxTypeError.Location = new System.Drawing.Point(148, 120);
            this.textBoxTypeError.Multiline = true;
            this.textBoxTypeError.Name = "textBoxTypeError";
            this.textBoxTypeError.Size = new System.Drawing.Size(29, 19);
            this.textBoxTypeError.TabIndex = 7;
            this.textBoxTypeError.Text = "0->1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 179);
            this.Controls.Add(this.textBoxTypeError);
            this.Controls.Add(this.textBoxFixed);
            this.Controls.Add(this.Fix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.GenCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenCode;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Fix;
        private System.Windows.Forms.TextBox textBoxFixed;
        private System.Windows.Forms.TextBox textBoxTypeError;
    }
}

