namespace QUAN_LY_THU_VIEN
{
    partial class Dangnhap
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
            this.bt_dang_nhap = new DevExpress.XtraEditors.SimpleButton();
            this.tb_ten_dang_nhap = new System.Windows.Forms.TextBox();
            this.tb_mat_khau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_dang_nhap
            // 
            this.bt_dang_nhap.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.bt_dang_nhap.Appearance.Options.UseBackColor = true;
            this.bt_dang_nhap.Location = new System.Drawing.Point(384, 267);
            this.bt_dang_nhap.Name = "bt_dang_nhap";
            this.bt_dang_nhap.Size = new System.Drawing.Size(123, 46);
            this.bt_dang_nhap.TabIndex = 0;
            this.bt_dang_nhap.Text = "Đăng nhập";
            // 
            // tb_ten_dang_nhap
            // 
            this.tb_ten_dang_nhap.Location = new System.Drawing.Point(310, 96);
            this.tb_ten_dang_nhap.Multiline = true;
            this.tb_ten_dang_nhap.Name = "tb_ten_dang_nhap";
            this.tb_ten_dang_nhap.Size = new System.Drawing.Size(289, 35);
            this.tb_ten_dang_nhap.TabIndex = 1;
            // 
            // tb_mat_khau
            // 
            this.tb_mat_khau.Location = new System.Drawing.Point(310, 190);
            this.tb_mat_khau.Multiline = true;
            this.tb_mat_khau.Name = "tb_mat_khau";
            this.tb_mat_khau.Size = new System.Drawing.Size(289, 35);
            this.tb_mat_khau.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QUAN_LY_THU_VIEN.Properties.Resources.IMG_20200513_223412;
            this.pictureEdit1.Location = new System.Drawing.Point(55, 65);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(193, 191);
            this.pictureEdit1.TabIndex = 5;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 361);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_mat_khau);
            this.Controls.Add(this.tb_ten_dang_nhap);
            this.Controls.Add(this.bt_dang_nhap);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bt_dang_nhap;
        private System.Windows.Forms.TextBox tb_ten_dang_nhap;
        private System.Windows.Forms.TextBox tb_mat_khau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}