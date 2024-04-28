namespace Window.UI_Giaodien
{
    partial class UC_Home
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
            this.components = new System.ComponentModel.Container();
            this.btnPic3 = new System.Windows.Forms.Button();
            this.btnPic2 = new System.Windows.Forms.Button();
            this.btnPic1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPic3
            // 
            this.btnPic3.BackColor = System.Drawing.Color.Transparent;
            this.btnPic3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic3.FlatAppearance.BorderSize = 0;
            this.btnPic3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic3.Location = new System.Drawing.Point(1089, 333);
            this.btnPic3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPic3.Name = "btnPic3";
            this.btnPic3.Size = new System.Drawing.Size(18, 16);
            this.btnPic3.TabIndex = 10;
            this.btnPic3.UseVisualStyleBackColor = false;
            this.btnPic3.Click += new System.EventHandler(this.btnPic3_Click);
            // 
            // btnPic2
            // 
            this.btnPic2.BackColor = System.Drawing.Color.Transparent;
            this.btnPic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic2.FlatAppearance.BorderSize = 0;
            this.btnPic2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic2.Location = new System.Drawing.Point(1089, 305);
            this.btnPic2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPic2.Name = "btnPic2";
            this.btnPic2.Size = new System.Drawing.Size(18, 16);
            this.btnPic2.TabIndex = 11;
            this.btnPic2.UseVisualStyleBackColor = false;
            this.btnPic2.Click += new System.EventHandler(this.btnPic2_Click);
            // 
            // btnPic1
            // 
            this.btnPic1.BackColor = System.Drawing.Color.Transparent;
            this.btnPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPic1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPic1.FlatAppearance.BorderSize = 0;
            this.btnPic1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic1.Location = new System.Drawing.Point(1089, 277);
            this.btnPic1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPic1.Name = "btnPic1";
            this.btnPic1.Size = new System.Drawing.Size(18, 16);
            this.btnPic1.TabIndex = 12;
            this.btnPic1.UseVisualStyleBackColor = false;
            this.btnPic1.Click += new System.EventHandler(this.btnPic1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picHome
            // 
            this.picHome.Location = new System.Drawing.Point(24, 22);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(1048, 640);
            this.picHome.TabIndex = 13;
            this.picHome.TabStop = false;
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.btnPic3);
            this.Controls.Add(this.btnPic2);
            this.Controls.Add(this.btnPic1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1132, 689);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Button btnPic3;
        private System.Windows.Forms.Button btnPic2;
        private System.Windows.Forms.Button btnPic1;
        private System.Windows.Forms.Timer timer1;
    }
}
