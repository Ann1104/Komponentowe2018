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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ramka)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ramka
            // 
            this.ramka.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ramka.Location = new System.Drawing.Point(8, 27);
            this.ramka.Name = "ramka";
            this.ramka.Size = new System.Drawing.Size(485, 340);
            this.ramka.TabIndex = 0;
            this.ramka.TabStop = false;
            this.ramka.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseDown);
            this.ramka.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseMove);
            this.ramka.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ramka_MouseUp);
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(499, 148);
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
            this.groupBox1.Location = new System.Drawing.Point(499, 27);
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
            this.numericUpDown1.Location = new System.Drawing.Point(499, 177);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edycjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyczyśćToolStripMenuItem,
            this.cofnijToolStripMenuItem,
            this.ponówToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // wyczyśćToolStripMenuItem
            // 
            this.wyczyśćToolStripMenuItem.Name = "wyczyśćToolStripMenuItem";
            this.wyczyśćToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.wyczyśćToolStripMenuItem.Text = "Wyczyść";
            this.wyczyśćToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćToolStripMenuItem_Click);
            // 
            // cofnijToolStripMenuItem
            // 
            this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cofnijToolStripMenuItem.Text = "Cofnij";
            this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.cofnijToolStripMenuItem_Click);
            // 
            // ponówToolStripMenuItem
            // 
            this.ponówToolStripMenuItem.Name = "ponówToolStripMenuItem";
            this.ponówToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ponówToolStripMenuItem.Text = "Ponów";
            this.ponówToolStripMenuItem.Click += new System.EventHandler(this.ponówToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ramka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponówToolStripMenuItem;
    }
}

