namespace MD5Check
{
    partial class MD5CheckForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD5CheckForm));
            this.AddContextButton = new System.Windows.Forms.Button();
            this.RemoveContextButton = new System.Windows.Forms.Button();
            this.MD5ToCheckText = new System.Windows.Forms.TextBox();
            this.CheckIcon = new System.Windows.Forms.PictureBox();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.MD5FromFileText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CheckIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // AddContextButton
            // 
            this.AddContextButton.Location = new System.Drawing.Point(156, 113);
            this.AddContextButton.Name = "AddContextButton";
            this.AddContextButton.Size = new System.Drawing.Size(255, 30);
            this.AddContextButton.TabIndex = 0;
            this.AddContextButton.Text = "Add To Context Menu";
            this.AddContextButton.UseVisualStyleBackColor = true;
            this.AddContextButton.Click += new System.EventHandler(this.AddContextButton_Click);
            // 
            // RemoveContextButton
            // 
            this.RemoveContextButton.Location = new System.Drawing.Point(156, 149);
            this.RemoveContextButton.Name = "RemoveContextButton";
            this.RemoveContextButton.Size = new System.Drawing.Size(255, 30);
            this.RemoveContextButton.TabIndex = 1;
            this.RemoveContextButton.Text = "Remove From Context Menu";
            this.RemoveContextButton.UseVisualStyleBackColor = true;
            this.RemoveContextButton.Click += new System.EventHandler(this.RemoveContextButton_Click);
            // 
            // MD5ToCheckText
            // 
            this.MD5ToCheckText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5ToCheckText.Location = new System.Drawing.Point(98, 57);
            this.MD5ToCheckText.Name = "MD5ToCheckText";
            this.MD5ToCheckText.Size = new System.Drawing.Size(391, 26);
            this.MD5ToCheckText.TabIndex = 3;
            this.MD5ToCheckText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MD5ToCheckText.TextChanged += new System.EventHandler(this.MD5ToCheckText_TextChanged);
            // 
            // CheckIcon
            // 
            this.CheckIcon.Location = new System.Drawing.Point(495, 57);
            this.CheckIcon.Name = "CheckIcon";
            this.CheckIcon.Size = new System.Drawing.Size(26, 26);
            this.CheckIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckIcon.TabIndex = 4;
            this.CheckIcon.TabStop = false;
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.White;
            this.IconList.Images.SetKeyName(0, "green_tick.png");
            this.IconList.Images.SetKeyName(1, "red_x.png");
            // 
            // MD5FromFileText
            // 
            this.MD5FromFileText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.MD5FromFileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5FromFileText.Location = new System.Drawing.Point(98, 25);
            this.MD5FromFileText.Name = "MD5FromFileText";
            this.MD5FromFileText.ReadOnly = true;
            this.MD5FromFileText.Size = new System.Drawing.Size(391, 26);
            this.MD5FromFileText.TabIndex = 5;
            this.MD5FromFileText.Text = "233c948203383fa078434cc3f8f925cb";
            this.MD5FromFileText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MD5CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 206);
            this.Controls.Add(this.MD5FromFileText);
            this.Controls.Add(this.CheckIcon);
            this.Controls.Add(this.MD5ToCheckText);
            this.Controls.Add(this.RemoveContextButton);
            this.Controls.Add(this.AddContextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MD5CheckForm";
            this.Text = "MD5Check";
            this.Load += new System.EventHandler(this.MD5CheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddContextButton;
        private System.Windows.Forms.Button RemoveContextButton;
        private System.Windows.Forms.TextBox MD5ToCheckText;
        private System.Windows.Forms.PictureBox CheckIcon;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.TextBox MD5FromFileText;
    }
}

