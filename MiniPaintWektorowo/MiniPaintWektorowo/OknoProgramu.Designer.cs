namespace MiniPaintWektorowo
{
    partial class OknoProgramu
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKolorLinii = new System.Windows.Forms.Button();
            this.groupBoxKsztalt = new System.Windows.Forms.GroupBox();
            this.radioButtonElipsa = new System.Windows.Forms.RadioButton();
            this.radioButtonProstokat = new System.Windows.Forms.RadioButton();
            this.radioButtonProsta = new System.Windows.Forms.RadioButton();
            this.radioButtonKrzywa = new System.Windows.Forms.RadioButton();
            this.pictureBoxRamka = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKolorWypelnienia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGruboscLinii = new System.Windows.Forms.NumericUpDown();
            this.groupBoxKsztalt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGruboscLinii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kolor linii";
            // 
            // buttonKolorLinii
            // 
            this.buttonKolorLinii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonKolorLinii.Location = new System.Drawing.Point(530, 159);
            this.buttonKolorLinii.Name = "buttonKolorLinii";
            this.buttonKolorLinii.Size = new System.Drawing.Size(32, 23);
            this.buttonKolorLinii.TabIndex = 6;
            this.buttonKolorLinii.UseVisualStyleBackColor = false;
            this.buttonKolorLinii.Click += new System.EventHandler(this.buttonKolorLinii_Click);
            // 
            // groupBoxKsztalt
            // 
            this.groupBoxKsztalt.Controls.Add(this.radioButtonElipsa);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonProstokat);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonProsta);
            this.groupBoxKsztalt.Controls.Add(this.radioButtonKrzywa);
            this.groupBoxKsztalt.Location = new System.Drawing.Point(463, 12);
            this.groupBoxKsztalt.Name = "groupBoxKsztalt";
            this.groupBoxKsztalt.Size = new System.Drawing.Size(99, 118);
            this.groupBoxKsztalt.TabIndex = 5;
            this.groupBoxKsztalt.TabStop = false;
            this.groupBoxKsztalt.Text = "Kształt";
            // 
            // radioButtonElipsa
            // 
            this.radioButtonElipsa.AutoSize = true;
            this.radioButtonElipsa.Location = new System.Drawing.Point(8, 89);
            this.radioButtonElipsa.Name = "radioButtonElipsa";
            this.radioButtonElipsa.Size = new System.Drawing.Size(53, 17);
            this.radioButtonElipsa.TabIndex = 3;
            this.radioButtonElipsa.TabStop = true;
            this.radioButtonElipsa.Text = "Elipsa";
            this.radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // radioButtonProstokat
            // 
            this.radioButtonProstokat.AutoSize = true;
            this.radioButtonProstokat.Location = new System.Drawing.Point(8, 66);
            this.radioButtonProstokat.Name = "radioButtonProstokat";
            this.radioButtonProstokat.Size = new System.Drawing.Size(70, 17);
            this.radioButtonProstokat.TabIndex = 2;
            this.radioButtonProstokat.TabStop = true;
            this.radioButtonProstokat.Text = "Prostokąt";
            this.radioButtonProstokat.UseVisualStyleBackColor = true;
            // 
            // radioButtonProsta
            // 
            this.radioButtonProsta.AutoSize = true;
            this.radioButtonProsta.Location = new System.Drawing.Point(8, 43);
            this.radioButtonProsta.Name = "radioButtonProsta";
            this.radioButtonProsta.Size = new System.Drawing.Size(55, 17);
            this.radioButtonProsta.TabIndex = 1;
            this.radioButtonProsta.TabStop = true;
            this.radioButtonProsta.Text = "Prosta";
            this.radioButtonProsta.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrzywa
            // 
            this.radioButtonKrzywa.AutoSize = true;
            this.radioButtonKrzywa.Location = new System.Drawing.Point(8, 20);
            this.radioButtonKrzywa.Name = "radioButtonKrzywa";
            this.radioButtonKrzywa.Size = new System.Drawing.Size(59, 17);
            this.radioButtonKrzywa.TabIndex = 0;
            this.radioButtonKrzywa.TabStop = true;
            this.radioButtonKrzywa.Text = "Krzywa";
            this.radioButtonKrzywa.UseVisualStyleBackColor = true;
            // 
            // pictureBoxRamka
            // 
            this.pictureBoxRamka.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxRamka.Name = "pictureBoxRamka";
            this.pictureBoxRamka.Size = new System.Drawing.Size(444, 296);
            this.pictureBoxRamka.TabIndex = 4;
            this.pictureBoxRamka.TabStop = false;
            this.pictureBoxRamka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxRamka.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxRamka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRamka_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolor tła";
            // 
            // buttonKolorWypelnienia
            // 
            this.buttonKolorWypelnienia.BackColor = System.Drawing.Color.Yellow;
            this.buttonKolorWypelnienia.Location = new System.Drawing.Point(530, 188);
            this.buttonKolorWypelnienia.Name = "buttonKolorWypelnienia";
            this.buttonKolorWypelnienia.Size = new System.Drawing.Size(32, 23);
            this.buttonKolorWypelnienia.TabIndex = 8;
            this.buttonKolorWypelnienia.UseVisualStyleBackColor = false;
            this.buttonKolorWypelnienia.Click += new System.EventHandler(this.buttonKolorWypelnienia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grubość linii";
            // 
            // numericUpDownGruboscLinii
            // 
            this.numericUpDownGruboscLinii.Location = new System.Drawing.Point(530, 133);
            this.numericUpDownGruboscLinii.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownGruboscLinii.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGruboscLinii.Name = "numericUpDownGruboscLinii";
            this.numericUpDownGruboscLinii.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownGruboscLinii.TabIndex = 11;
            this.numericUpDownGruboscLinii.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 319);
            this.Controls.Add(this.numericUpDownGruboscLinii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKolorWypelnienia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKolorLinii);
            this.Controls.Add(this.groupBoxKsztalt);
            this.Controls.Add(this.pictureBoxRamka);
            this.Name = "OknoProgramu";
            this.Text = "MiniPaint wektorowy";
            this.groupBoxKsztalt.ResumeLayout(false);
            this.groupBoxKsztalt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGruboscLinii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKolorLinii;
        private System.Windows.Forms.GroupBox groupBoxKsztalt;
        private System.Windows.Forms.RadioButton radioButtonElipsa;
        private System.Windows.Forms.RadioButton radioButtonProstokat;
        private System.Windows.Forms.RadioButton radioButtonProsta;
        private System.Windows.Forms.RadioButton radioButtonKrzywa;
        private System.Windows.Forms.PictureBox pictureBoxRamka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKolorWypelnienia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGruboscLinii;
    }
}

