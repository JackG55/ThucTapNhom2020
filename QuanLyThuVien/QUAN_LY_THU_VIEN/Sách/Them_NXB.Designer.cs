namespace QUAN_LY_THU_VIEN.Sách
{
    partial class Them_NXB
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
            this.tb_ma_NXB = new DevExpress.XtraEditors.TextEdit();
            this.tb_ten_NXB = new DevExpress.XtraEditors.TextEdit();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dia_chi = new DevExpress.XtraEditors.TextEdit();
            this.tb_email = new DevExpress.XtraEditors.TextEdit();
            this.tb_ndd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_NXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_NXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dia_chi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ndd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Xuất bản";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà Xuất bản";
            // 
            // tb_ma_NXB
            // 
            this.tb_ma_NXB.Location = new System.Drawing.Point(213, 47);
            this.tb_ma_NXB.Name = "tb_ma_NXB";
            this.tb_ma_NXB.Size = new System.Drawing.Size(137, 22);
            this.tb_ma_NXB.TabIndex = 2;
            // 
            // tb_ten_NXB
            // 
            this.tb_ten_NXB.Location = new System.Drawing.Point(213, 115);
            this.tb_ten_NXB.Name = "tb_ten_NXB";
            this.tb_ten_NXB.Size = new System.Drawing.Size(137, 22);
            this.tb_ten_NXB.TabIndex = 3;
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(84, 385);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(233, 385);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "Huỷ";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(46, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(46, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "TT người địa diện ";
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.Location = new System.Drawing.Point(213, 187);
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(137, 22);
            this.tb_dia_chi.TabIndex = 9;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(213, 257);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(137, 22);
            this.tb_email.TabIndex = 10;
            // 
            // tb_ndd
            // 
            this.tb_ndd.Location = new System.Drawing.Point(213, 318);
            this.tb_ndd.Name = "tb_ndd";
            this.tb_ndd.Size = new System.Drawing.Size(137, 22);
            this.tb_ndd.TabIndex = 11;
            // 
            // Them_NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 480);
            this.Controls.Add(this.tb_ndd);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_dia_chi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tb_ten_NXB);
            this.Controls.Add(this.tb_ma_NXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Them_NXB";
            this.Text = "Them_NXB";
            ((System.ComponentModel.ISupportInitialize)(this.tb_ma_NXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ten_NXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dia_chi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ndd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tb_ma_NXB;
        private DevExpress.XtraEditors.TextEdit tb_ten_NXB;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit tb_dia_chi;
        private DevExpress.XtraEditors.TextEdit tb_email;
        private DevExpress.XtraEditors.TextEdit tb_ndd;
    }
}