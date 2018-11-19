namespace myCircleApp
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
            this.eraseCircle = new System.Windows.Forms.Button();
            this.createCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
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
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Border Width (px)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Circle Size (px)";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow",
            "Orange",
            "Purple",
            "Black",
            "Pink"});
            this.comboBox1.Location = new System.Drawing.Point(13, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Blue";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "20",
            "40",
            "80",
            "100",
            "120",
            "140",
            "160",
            "180"});
            this.comboBox2.Location = new System.Drawing.Point(12, 280);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "100";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(133, 280);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(56, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.Text = "4";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(313, 311);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eraseCircle);
            this.Controls.Add(this.createCircle);
            this.Name = "Form1";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

