namespace ProgramZZamianaPol
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.bZamien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.liczba1 = new System.Windows.Forms.TextBox();
            this.liczba2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.TextBox();
            this.dzialanie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(23, 40);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(174, 20);
            this.text1.TabIndex = 0;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(292, 40);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(171, 20);
            this.text2.TabIndex = 1;
            // 
            // bZamien
            // 
            this.bZamien.Location = new System.Drawing.Point(203, 40);
            this.bZamien.Name = "bZamien";
            this.bZamien.Size = new System.Drawing.Size(75, 23);
            this.bZamien.TabIndex = 2;
            this.bZamien.Text = "<>";
            this.bZamien.UseVisualStyleBackColor = true;
            this.bZamien.Click += new System.EventHandler(this.bZamien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pole1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pole2";
            // 
            // liczba1
            // 
            this.liczba1.Location = new System.Drawing.Point(2, 118);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(100, 20);
            this.liczba1.TabIndex = 5;
            this.liczba1.TextChanged += new System.EventHandler(this.liczba1_TextChanged);
            // 
            // liczba2
            // 
            this.liczba2.Location = new System.Drawing.Point(151, 118);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(100, 20);
            this.liczba2.TabIndex = 6;
            this.liczba2.TextChanged += new System.EventHandler(this.liczba2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(365, 118);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(150, 20);
            this.suma.TabIndex = 10;
            // 
            // dzialanie
            // 
            this.dzialanie.FormattingEnabled = true;
            this.dzialanie.Location = new System.Drawing.Point(108, 116);
            this.dzialanie.Name = "dzialanie";
            this.dzialanie.Size = new System.Drawing.Size(37, 21);
            this.dzialanie.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "_________________________________________________________________________________" +
    "_____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "liczba1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "liczba2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 246);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dzialanie);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bZamien);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Button bZamien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox liczba1;
        private System.Windows.Forms.TextBox liczba2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox suma;
        private System.Windows.Forms.ComboBox dzialanie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

