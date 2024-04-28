namespace Window.UI.User
{
    partial class UC_Item_Service
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_gia = new System.Windows.Forms.Label();
            this.lb_tendichvu = new System.Windows.Forms.Label();
            this.lb_madichvu = new System.Windows.Forms.Label();
            this.btn_mua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_dichvu = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lb_gia);
            this.panel1.Controls.Add(this.lb_tendichvu);
            this.panel1.Controls.Add(this.lb_madichvu);
            this.panel1.Controls.Add(this.btn_mua);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_dichvu);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 527);
            this.panel1.TabIndex = 0;
            // 
            // lb_gia
            // 
            this.lb_gia.AutoSize = true;
            this.lb_gia.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_gia.Location = new System.Drawing.Point(135, 412);
            this.lb_gia.Name = "lb_gia";
            this.lb_gia.Size = new System.Drawing.Size(0, 21);
            this.lb_gia.TabIndex = 236;
            // 
            // lb_tendichvu
            // 
            this.lb_tendichvu.AutoSize = true;
            this.lb_tendichvu.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendichvu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_tendichvu.Location = new System.Drawing.Point(135, 363);
            this.lb_tendichvu.Name = "lb_tendichvu";
            this.lb_tendichvu.Size = new System.Drawing.Size(0, 21);
            this.lb_tendichvu.TabIndex = 235;
            // 
            // lb_madichvu
            // 
            this.lb_madichvu.AutoSize = true;
            this.lb_madichvu.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madichvu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_madichvu.Location = new System.Drawing.Point(135, 314);
            this.lb_madichvu.Name = "lb_madichvu";
            this.lb_madichvu.Size = new System.Drawing.Size(0, 21);
            this.lb_madichvu.TabIndex = 234;
            // 
            // btn_mua
            // 
            this.btn_mua.Location = new System.Drawing.Point(11, 463);
            this.btn_mua.Name = "btn_mua";
            this.btn_mua.Size = new System.Drawing.Size(340, 45);
            this.btn_mua.TabIndex = 233;
            this.btn_mua.Text = "Mua";
            this.btn_mua.UseVisualStyleBackColor = true;
            this.btn_mua.Click += new System.EventHandler(this.btn_mua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(16, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 21);
            this.label7.TabIndex = 232;
            this.label7.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(16, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 231;
            this.label5.Text = "Mã dịch vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 230;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // pic_dichvu
            // 
            this.pic_dichvu.Location = new System.Drawing.Point(10, 14);
            this.pic_dichvu.Name = "pic_dichvu";
            this.pic_dichvu.Size = new System.Drawing.Size(343, 271);
            this.pic_dichvu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dichvu.TabIndex = 229;
            this.pic_dichvu.TabStop = false;
            // 
            // UC_Item_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Item_Service";
            this.Size = new System.Drawing.Size(390, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dichvu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_gia;
        private System.Windows.Forms.Label lb_tendichvu;
        private System.Windows.Forms.Label lb_madichvu;
        private System.Windows.Forms.Button btn_mua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_dichvu;
    }
}
