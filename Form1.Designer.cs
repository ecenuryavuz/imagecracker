namespace Process07
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlRotate = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.numDegreesRed = new System.Windows.Forms.NumericUpDown();
            this.lblGreen = new System.Windows.Forms.Label();
            this.numDegreesGreen = new System.Windows.Forms.NumericUpDown();
            this.lblBlue = new System.Windows.Forms.Label();
            this.numDegreesBlue = new System.Windows.Forms.NumericUpDown();
            this.lblDegreeRotation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlRotate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(414, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 280);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(414, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 280);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "UPLOAD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "SHRINK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(170, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "SAVE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Turquoise;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "SLIDE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Turquoise;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(173, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Turquoise;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(12, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 185);
            this.button6.TabIndex = 7;
            this.button6.Text = "CHANNEL ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 9;
            // 
            // pnlRotate
            // 
            this.pnlRotate.BackColor = System.Drawing.Color.Turquoise;
            this.pnlRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRotate.Controls.Add(this.lblRed);
            this.pnlRotate.Controls.Add(this.numDegreesRed);
            this.pnlRotate.Controls.Add(this.lblGreen);
            this.pnlRotate.Controls.Add(this.numDegreesGreen);
            this.pnlRotate.Controls.Add(this.lblBlue);
            this.pnlRotate.Controls.Add(this.numDegreesBlue);
            this.pnlRotate.Controls.Add(this.lblDegreeRotation);
            this.pnlRotate.Location = new System.Drawing.Point(173, 425);
            this.pnlRotate.Name = "pnlRotate";
            this.pnlRotate.Size = new System.Drawing.Size(155, 185);
            this.pnlRotate.TabIndex = 25;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(7, 137);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(44, 23);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red:";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDegreesRed
            // 
            this.numDegreesRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDegreesRed.DecimalPlaces = 2;
            this.numDegreesRed.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDegreesRed.Location = new System.Drawing.Point(70, 138);
            this.numDegreesRed.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesRed.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesRed.Name = "numDegreesRed";
            this.numDegreesRed.Size = new System.Drawing.Size(63, 19);
            this.numDegreesRed.TabIndex = 23;
            this.numDegreesRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(7, 99);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(58, 23);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green:";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDegreesGreen
            // 
            this.numDegreesGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDegreesGreen.DecimalPlaces = 2;
            this.numDegreesGreen.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDegreesGreen.Location = new System.Drawing.Point(70, 100);
            this.numDegreesGreen.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesGreen.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesGreen.Name = "numDegreesGreen";
            this.numDegreesGreen.Size = new System.Drawing.Size(63, 19);
            this.numDegreesGreen.TabIndex = 22;
            this.numDegreesGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(7, 61);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(44, 23);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue:";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDegreesBlue
            // 
            this.numDegreesBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDegreesBlue.DecimalPlaces = 2;
            this.numDegreesBlue.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numDegreesBlue.Location = new System.Drawing.Point(70, 62);
            this.numDegreesBlue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesBlue.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesBlue.Name = "numDegreesBlue";
            this.numDegreesBlue.Size = new System.Drawing.Size(63, 19);
            this.numDegreesBlue.TabIndex = 21;
            this.numDegreesBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDegreeRotation
            // 
            this.lblDegreeRotation.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegreeRotation.Location = new System.Drawing.Point(8, 7);
            this.lblDegreeRotation.Name = "lblDegreeRotation";
            this.lblDegreeRotation.Size = new System.Drawing.Size(142, 30);
            this.lblDegreeRotation.TabIndex = 0;
            this.lblDegreeRotation.Text = "DEGREE";
            this.lblDegreeRotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "SIZE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "OFFSET";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGray;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(169, 63);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 45);
            this.button7.TabIndex = 28;
            this.button7.Text = "REFRESH";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(734, 628);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRotate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "IMAGE CRACKER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlRotate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlRotate;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.NumericUpDown numDegreesRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.NumericUpDown numDegreesGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.NumericUpDown numDegreesBlue;
        private System.Windows.Forms.Label lblDegreeRotation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
    }
}

