namespace WykresyPart2
{
    partial class UserControlFunkcja
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownCzestotliwosc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAmplituda = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzestotliwosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplituda)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDownCzestotliwosc
            // 
            this.numericUpDownCzestotliwosc.Location = new System.Drawing.Point(0, 24);
            this.numericUpDownCzestotliwosc.Name = "numericUpDownCzestotliwosc";
            this.numericUpDownCzestotliwosc.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownCzestotliwosc.TabIndex = 1;
            this.numericUpDownCzestotliwosc.ValueChanged += new System.EventHandler(this.numericUpDownCzestotliwosc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hz";
            // 
            // numericUpDownAmplituda
            // 
            this.numericUpDownAmplituda.Location = new System.Drawing.Point(106, 24);
            this.numericUpDownAmplituda.Name = "numericUpDownAmplituda";
            this.numericUpDownAmplituda.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownAmplituda.TabIndex = 3;
            this.numericUpDownAmplituda.ValueChanged += new System.EventHandler(this.numericUpDownAmplituda_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "uV";
            // 
            // UserControlFunkcja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAmplituda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownCzestotliwosc);
            this.Controls.Add(this.checkBox1);
            this.Name = "UserControlFunkcja";
            this.Size = new System.Drawing.Size(200, 51);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCzestotliwosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmplituda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownCzestotliwosc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmplituda;
        private System.Windows.Forms.Label label2;
    }
}
