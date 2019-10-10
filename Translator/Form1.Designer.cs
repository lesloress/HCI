namespace Translator
{
    partial class firstTr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputLang = new System.Windows.Forms.ComboBox();
            this.inputLang = new System.Windows.Forms.ComboBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.changeLang = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.changeLang);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.outputLang);
            this.panel1.Controls.Add(this.inputLang);
            this.panel1.Controls.Add(this.outputBox);
            this.panel1.Controls.Add(this.inputBox);
            this.panel1.Location = new System.Drawing.Point(1, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 490);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(11, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 34);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(14, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 60);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(544, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 60);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(538, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Перевести на";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Перевести с";
            // 
            // outputLang
            // 
            this.outputLang.FormattingEnabled = true;
            this.outputLang.Location = new System.Drawing.Point(740, 41);
            this.outputLang.Name = "outputLang";
            this.outputLang.Size = new System.Drawing.Size(188, 40);
            this.outputLang.TabIndex = 3;
            // 
            // inputLang
            // 
            this.inputLang.FormattingEnabled = true;
            this.inputLang.Location = new System.Drawing.Point(192, 44);
            this.inputLang.Name = "inputLang";
            this.inputLang.Size = new System.Drawing.Size(188, 40);
            this.inputLang.TabIndex = 2;
            // 
            // outputBox
            // 
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(544, 132);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(455, 220);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.Location = new System.Drawing.Point(14, 132);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(455, 220);
            this.inputBox.TabIndex = 0;
            this.inputBox.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(544, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 34);
            this.panel5.TabIndex = 9;
            // 
            // changeLang
            // 
            this.changeLang.BackColor = System.Drawing.Color.LightBlue;
            this.changeLang.BackgroundImage = global::Translator.Properties.Resources.changeicon;
            this.changeLang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeLang.FlatAppearance.BorderSize = 0;
            this.changeLang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.changeLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLang.Location = new System.Drawing.Point(468, 44);
            this.changeLang.Name = "changeLang";
            this.changeLang.Size = new System.Drawing.Size(70, 42);
            this.changeLang.TabIndex = 10;
            this.changeLang.UseVisualStyleBackColor = false;
            // 
            // firstTr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 587);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "firstTr";
            this.Text = "Translator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox outputLang;
        private System.Windows.Forms.ComboBox inputLang;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button changeLang;
    }
}

