
namespace Quan_Ly_Phong_Hoc.Module
{
    partial class Frm_phonghoc
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
            this.btnThem = new System.Windows.Forms.Button();
            this.maphong = new System.Windows.Forms.TextBox();
            this.tenphong = new System.Windows.Forms.TextBox();
            this.succhua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mota = new System.Windows.Forms.TextBox();
            this.vitri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trangthai = new System.Windows.Forms.ComboBox();
            this.txtloai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(164, 188);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // maphong
            // 
            this.maphong.Location = new System.Drawing.Point(81, 26);
            this.maphong.Multiline = true;
            this.maphong.Name = "maphong";
            this.maphong.Size = new System.Drawing.Size(100, 20);
            this.maphong.TabIndex = 1;
            // 
            // tenphong
            // 
            this.tenphong.Location = new System.Drawing.Point(81, 62);
            this.tenphong.Name = "tenphong";
            this.tenphong.Size = new System.Drawing.Size(100, 20);
            this.tenphong.TabIndex = 2;
            // 
            // succhua
            // 
            this.succhua.Location = new System.Drawing.Point(260, 62);
            this.succhua.Name = "succhua";
            this.succhua.Size = new System.Drawing.Size(100, 20);
            this.succhua.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sức chứa";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(260, 188);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vị trí";
            // 
            // mota
            // 
            this.mota.Location = new System.Drawing.Point(260, 104);
            this.mota.Name = "mota";
            this.mota.Size = new System.Drawing.Size(100, 20);
            this.mota.TabIndex = 12;
            // 
            // vitri
            // 
            this.vitri.Location = new System.Drawing.Point(81, 104);
            this.vitri.Name = "vitri";
            this.vitri.Size = new System.Drawing.Size(100, 20);
            this.vitri.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Trạng thái";
            // 
            // trangthai
            // 
            this.trangthai.FormattingEnabled = true;
            this.trangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Đang sửa chữa",
            "tạm ngưng"});
            this.trangthai.Location = new System.Drawing.Point(81, 140);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(100, 21);
            this.trangthai.TabIndex = 17;
            // 
            // txtloai
            // 
            this.txtloai.FormattingEnabled = true;
            this.txtloai.Items.AddRange(new object[] {
            "Hoạt động",
            "Đang sửa chữa",
            "tạm ngưng"});
            this.txtloai.Location = new System.Drawing.Point(261, 26);
            this.txtloai.Name = "txtloai";
            this.txtloai.Size = new System.Drawing.Size(100, 21);
            this.txtloai.TabIndex = 18;
            // 
            // Frm_phonghoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 231);
            this.Controls.Add(this.txtloai);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mota);
            this.Controls.Add(this.vitri);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.succhua);
            this.Controls.Add(this.tenphong);
            this.Controls.Add(this.maphong);
            this.Controls.Add(this.btnThem);
            this.Name = "Frm_phonghoc";
            this.Text = "Frm_phonghoc";
            this.Load += new System.EventHandler(this.Frm_phonghoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox maphong;
        private System.Windows.Forms.TextBox tenphong;
        private System.Windows.Forms.TextBox succhua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mota;
        private System.Windows.Forms.TextBox vitri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox trangthai;
        private System.Windows.Forms.ComboBox txtloai;
    }
}