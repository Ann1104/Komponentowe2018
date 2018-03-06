namespace zaj5
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
            this.ramka = new System.Windows.Forms.PictureBox();
            this.bColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbNoLine = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ramka)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ramka
            // 
            this.ramka.Location = new System.Drawing.Point(14, 12);
            this.ramka.Name = "ramka";
            this.ramka.Size = new System.Drawing.Size(485, 355);
            this.ramka.TabIndex = 0;
            this.ramka.TabStop = false;
            this.ramka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseDown);
            this.ramka.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseMove);
            this.ramka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseUp);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(505, 13);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(107, 23);
            this.bColor.TabIndex = 1;
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbElipse);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.Controls.Add(this.rbNoLine);
            this.groupBox1.Location = new System.Drawing.Point(505, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kształt";
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(7, 89);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(52, 17);
            this.rbElipse.TabIndex = 3;
            this.rbElipse.TabStop = true;
            this.rbElipse.Text = "elipsa";
            this.rbElipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(7, 66);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(69, 17);
            this.rbRectangle.TabIndex = 2;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "prostokąt";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(7, 43);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(54, 17);
            this.rbLine.TabIndex = 1;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "prosta";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbNoLine
            // 
            this.rbNoLine.AutoSize = true;
            this.rbNoLine.Location = new System.Drawing.Point(7, 20);
            this.rbNoLine.Name = "rbNoLine";
            this.rbNoLine.Size = new System.Drawing.Size(58, 17);
            this.rbNoLine.TabIndex = 0;
            this.rbNoLine.TabStop = true;
            this.rbNoLine.Text = "krzywa";
            this.rbNoLine.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(505, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 379);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.ramka);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ramka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ramka;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbNoLine;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

