namespace myCircleApp
{
    partial class CircleMakerForm
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
        public void InitializeComponent()
        {
            this.eraseCircle = new System.Windows.Forms.Button();
            this.createCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColourComboBox = new System.Windows.Forms.ComboBox();
            this.CircleSizeBox = new System.Windows.Forms.ComboBox();
            this.BorderWidthBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // eraseCircle
            // 
            this.eraseCircle.Location = new System.Drawing.Point(226, 278);
            this.eraseCircle.Name = "eraseCircle";
            this.eraseCircle.Size = new System.Drawing.Size(75, 23);
            this.eraseCircle.TabIndex = 1;
            this.eraseCircle.Text = "Erase Circle";
            this.eraseCircle.UseVisualStyleBackColor = true;
            this.eraseCircle.Click += new System.EventHandler(this.eraseCircle_Click);
            // 
            // createCircle
            // 
            this.createCircle.Location = new System.Drawing.Point(133, 229);
            this.createCircle.Name = "createCircle";
            this.createCircle.Size = new System.Drawing.Size(168, 23);
            this.createCircle.TabIndex = 0;
            this.createCircle.Text = "Create Circle";
            this.createCircle.UseVisualStyleBackColor = true;
            this.createCircle.Click += new System.EventHandler(this.createCircle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Border Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Circle Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Circle Colour";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ColourComboBox
            // 
            this.ColourComboBox.AllowDrop = true;
            this.ColourComboBox.FormattingEnabled = true;
            this.ColourComboBox.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow",
            "Orange",
            "Purple",
            "Black",
            "Pink"});
            this.ColourComboBox.Location = new System.Drawing.Point(13, 229);
            this.ColourComboBox.Name = "ColourComboBox";
            this.ColourComboBox.Size = new System.Drawing.Size(114, 21);
            this.ColourComboBox.TabIndex = 4;
            this.ColourComboBox.Text = "Blue";
            this.ColourComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // CircleSizeBox
            // 
            this.CircleSizeBox.FormattingEnabled = true;
            this.CircleSizeBox.Items.AddRange(new object[] {
            "20",
            "40",
            "80",
            "100",
            "120",
            "140",
            "160",
            "180"});
            this.CircleSizeBox.Location = new System.Drawing.Point(12, 280);
            this.CircleSizeBox.Name = "CircleSizeBox";
            this.CircleSizeBox.Size = new System.Drawing.Size(52, 21);
            this.CircleSizeBox.TabIndex = 4;
            this.CircleSizeBox.Text = "100";
            this.CircleSizeBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // BorderWidthBox
            // 
            this.BorderWidthBox.FormattingEnabled = true;
            this.BorderWidthBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "6",
            "8",
            "10",
            "12"});
            this.BorderWidthBox.Location = new System.Drawing.Point(133, 280);
            this.BorderWidthBox.Name = "BorderWidthBox";
            this.BorderWidthBox.Size = new System.Drawing.Size(56, 21);
            this.BorderWidthBox.TabIndex = 4;
            this.BorderWidthBox.Text = "4";
            this.BorderWidthBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxes_SelectedIndexChanged);
            // 
            // CircleMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(313, 311);
            this.Controls.Add(this.BorderWidthBox);
            this.Controls.Add(this.CircleSizeBox);
            this.Controls.Add(this.ColourComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eraseCircle);
            this.Controls.Add(this.createCircle);
            this.Name = "CircleMakerForm";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button eraseCircle;
        private System.Windows.Forms.Button createCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ComboBox ColourComboBox;
        public System.Windows.Forms.ComboBox CircleSizeBox;
        public System.Windows.Forms.ComboBox BorderWidthBox;
    }
}

