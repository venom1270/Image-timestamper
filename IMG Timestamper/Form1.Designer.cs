namespace IMG_Timestamper
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
            this.bTimestampImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOffsetX = new System.Windows.Forms.NumericUpDown();
            this.tbOffsetY = new System.Windows.Forms.NumericUpDown();
            this.bSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFontSize = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bChooseColor = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cbScaled = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // bTimestampImages
            // 
            this.bTimestampImages.Enabled = false;
            this.bTimestampImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTimestampImages.Location = new System.Drawing.Point(15, 252);
            this.bTimestampImages.Name = "bTimestampImages";
            this.bTimestampImages.Size = new System.Drawing.Size(251, 33);
            this.bTimestampImages.TabIndex = 0;
            this.bTimestampImages.Text = "Timestamp images!";
            this.bTimestampImages.UseVisualStyleBackColor = true;
            this.bTimestampImages.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X right side offset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y bottom offset:";
            // 
            // tbOffsetX
            // 
            this.tbOffsetX.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbOffsetX.Location = new System.Drawing.Point(141, 21);
            this.tbOffsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbOffsetX.Minimum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.tbOffsetX.Name = "tbOffsetX";
            this.tbOffsetX.Size = new System.Drawing.Size(120, 22);
            this.tbOffsetX.TabIndex = 3;
            this.tbOffsetX.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // tbOffsetY
            // 
            this.tbOffsetY.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tbOffsetY.Location = new System.Drawing.Point(141, 51);
            this.tbOffsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbOffsetY.Name = "tbOffsetY";
            this.tbOffsetY.Size = new System.Drawing.Size(120, 22);
            this.tbOffsetY.TabIndex = 4;
            this.tbOffsetY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // bSelectFolder
            // 
            this.bSelectFolder.Location = new System.Drawing.Point(15, 213);
            this.bSelectFolder.Name = "bSelectFolder";
            this.bSelectFolder.Size = new System.Drawing.Size(251, 33);
            this.bSelectFolder.TabIndex = 5;
            this.bSelectFolder.Text = "Select folder";
            this.bSelectFolder.UseVisualStyleBackColor = true;
            this.bSelectFolder.Click += new System.EventHandler(this.bSelectFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Font size:";
            // 
            // tbFontSize
            // 
            this.tbFontSize.Location = new System.Drawing.Point(141, 103);
            this.tbFontSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.tbFontSize.Name = "tbFontSize";
            this.tbFontSize.Size = new System.Drawing.Size(120, 22);
            this.tbFontSize.TabIndex = 7;
            this.tbFontSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // bChooseColor
            // 
            this.bChooseColor.Location = new System.Drawing.Point(15, 157);
            this.bChooseColor.Name = "bChooseColor";
            this.bChooseColor.Size = new System.Drawing.Size(251, 28);
            this.bChooseColor.TabIndex = 8;
            this.bChooseColor.Text = "Choose color";
            this.bChooseColor.UseVisualStyleBackColor = true;
            this.bChooseColor.Click += new System.EventHandler(this.bChooseColor_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 292);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // cbScaled
            // 
            this.cbScaled.AutoSize = true;
            this.cbScaled.Checked = true;
            this.cbScaled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbScaled.Location = new System.Drawing.Point(15, 123);
            this.cbScaled.Name = "cbScaled";
            this.cbScaled.Size = new System.Drawing.Size(91, 21);
            this.cbScaled.TabIndex = 10;
            this.cbScaled.Text = "Scale text";
            this.cbScaled.UseVisualStyleBackColor = true;
            this.cbScaled.CheckedChanged += new System.EventHandler(this.cbScaled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 327);
            this.Controls.Add(this.cbScaled);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bChooseColor);
            this.Controls.Add(this.tbFontSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSelectFolder);
            this.Controls.Add(this.tbOffsetY);
            this.Controls.Add(this.tbOffsetX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTimestampImages);
            this.Name = "Form1";
            this.Text = "Timestamper";
            ((System.ComponentModel.ISupportInitialize)(this.tbOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bTimestampImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbOffsetX;
        private System.Windows.Forms.NumericUpDown tbOffsetY;
        private System.Windows.Forms.Button bSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown tbFontSize;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button bChooseColor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox cbScaled;
    }
}

