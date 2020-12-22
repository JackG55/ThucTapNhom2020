namespace QUAN_LY_THU_VIEN.Sách
{
    partial class Them_the_loai
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ma_the_loai = new DevExpress.XtraEditors.TextEdit();
            this.tb_ten_the_loai = new DevExpress.XtraEditors.TextEdit();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_the_loai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_the_loai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thể loại";
            // 
            // tb_ma_the_loai
            // 
            this.tb_ma_the_loai.Location = new System.Drawing.Point(206, 50);
            this.tb_ma_the_loai.Name = "tb_ma_the_loai";
            this.tb_ma_the_loai.Size = new System.Drawing.Size(125, 22);
            this.tb_ma_the_loai.TabIndex = 2;
            // 
            // tb_ten_the_loai
            // 
            this.tb_ten_the_loai.Location = new System.Drawing.Point(206, 112);
            this.tb_ten_the_loai.Name = "tb_ten_the_loai";
            this.tb_ten_the_loai.Size = new System.Drawing.Size(125, 22);
            this.tb_ten_the_loai.TabIndex = 3;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(83, 169);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(256, 169);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(75, 23);
            this.bt_huy.TabIndex = 5;
            this.bt_huy.Text = "Huỷ";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // Them_the_loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 238);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_ten_the_loai);
            this.Controls.Add(this.tb_ma_the_loai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Them_the_loai";
            this.Text = "Them_the_loai";
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_the_loai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_the_loai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tb_ma_the_loai;
        private DevExpress.XtraEditors.TextEdit tb_ten_the_loai;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_huy;
    }
}