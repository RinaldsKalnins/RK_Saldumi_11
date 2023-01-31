namespace RK_Saldumi_11
{
    partial class Form1
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
            this.Apreķināšana = new System.Windows.Forms.Button();
            this.daudzums = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Apreķināšana
            // 
            this.Apreķināšana.Location = new System.Drawing.Point(110, 133);
            this.Apreķināšana.Name = "Apreķināšana";
            this.Apreķināšana.Size = new System.Drawing.Size(75, 23);
            this.Apreķināšana.TabIndex = 0;
            this.Apreķināšana.Text = "Aprēķināšana";
            this.Apreķināšana.UseVisualStyleBackColor = true;
            this.Apreķināšana.Click += new System.EventHandler(this.Apreķināšana_Click);
            // 
            // daudzums
            // 
            this.daudzums.Location = new System.Drawing.Point(110, 85);
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(100, 20);
            this.daudzums.TabIndex = 1;
            this.daudzums.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.daudzums);
            this.Controls.Add(this.Apreķināšana);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Apreķināšana;
        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

