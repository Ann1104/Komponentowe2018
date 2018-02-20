namespace PierwszyProjekt
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
            this.bPowitalny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bPowitalny
            // 
            this.bPowitalny.Location = new System.Drawing.Point(185, 52);
            this.bPowitalny.Name = "bPowitalny";
            this.bPowitalny.Size = new System.Drawing.Size(75, 23);
            this.bPowitalny.TabIndex = 0;
            this.bPowitalny.Text = "Powitanie";
            this.bPowitalny.UseVisualStyleBackColor = true;
            this.bPowitalny.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wpisz imie:";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(79, 21);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(181, 20);
            this.textBoxImie.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPowitalny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPowitalny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImie;
    }
}

