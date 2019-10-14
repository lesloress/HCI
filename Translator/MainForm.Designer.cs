namespace Translator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.but1 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.but1);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Location = new System.Drawing.Point(42, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 235);
            this.panel1.TabIndex = 3;
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but1.ForeColor = System.Drawing.Color.Red;
            this.but1.Location = new System.Drawing.Point(24, 23);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(217, 195);
            this.but1.TabIndex = 3;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.But1_Click);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but3.ForeColor = System.Drawing.Color.Red;
            this.but3.Location = new System.Drawing.Point(530, 23);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(217, 195);
            this.but3.TabIndex = 2;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.But3_Click);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.but2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but2.ForeColor = System.Drawing.Color.Red;
            this.but2.Location = new System.Drawing.Point(280, 23);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(217, 195);
            this.but2.TabIndex = 1;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.But2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but3;
    }
}