namespace RAWR
{
    partial class CreateLevelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLevelForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playbutton1 = new System.Windows.Forms.PictureBox();
            this.leftarrow1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftarrow1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(364, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 70);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // playbutton1
            // 
            this.playbutton1.BackColor = System.Drawing.Color.Transparent;
            this.playbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playbutton1.BackgroundImage")));
            this.playbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playbutton1.Location = new System.Drawing.Point(855, 12);
            this.playbutton1.Name = "playbutton1";
            this.playbutton1.Size = new System.Drawing.Size(117, 70);
            this.playbutton1.TabIndex = 2;
            this.playbutton1.TabStop = false;
            this.playbutton1.Click += new System.EventHandler(this.playbutton1_Click);
            this.playbutton1.MouseLeave += new System.EventHandler(this.playbutton1_MouseLeave);
            this.playbutton1.MouseHover += new System.EventHandler(this.playbutton1_MouseHover);
            // 
            // leftarrow1
            // 
            this.leftarrow1.BackColor = System.Drawing.Color.Transparent;
            this.leftarrow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftarrow1.BackgroundImage")));
            this.leftarrow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftarrow1.Location = new System.Drawing.Point(12, 12);
            this.leftarrow1.Name = "leftarrow1";
            this.leftarrow1.Size = new System.Drawing.Size(94, 77);
            this.leftarrow1.TabIndex = 3;
            this.leftarrow1.TabStop = false;
            this.leftarrow1.Click += new System.EventHandler(this.leftarrow1_Click_1);
            this.leftarrow1.MouseLeave += new System.EventHandler(this.leftarrow1_MouseLeave);
            this.leftarrow1.MouseHover += new System.EventHandler(this.leftarrow1_MouseHover);
            // 
            // CreateLevelForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.leftarrow1);
            this.Controls.Add(this.playbutton1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftarrow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox playbutton1;
        private System.Windows.Forms.PictureBox leftarrow1;
    }
}

