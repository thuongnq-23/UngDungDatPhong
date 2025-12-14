
namespace Quan_Ly_Phong_Hoc.Module
{
    partial class Frm_Ca_hoc
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
            this.txttrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgiokt = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtgiobd = new System.Windows.Forms.TextBox();
            this.txtmaca = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttrangthai
            // 
            this.txttrangthai.FormattingEnabled = true;
            this.txttrangthai.Items.AddRange(new object[] {
            "Hoạt động",
            "Đã khóa"});
            this.txttrangthai.Location = new System.Drawing.Point(96, 101);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(100, 21);
            this.txttrangthai.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Giờ kết thúc";
            // 
            // txtgiokt
            // 
            this.txtgiokt.Location = new System.Drawing.Point(275, 63);
            this.txtgiokt.Name = "txtgiokt";
            this.txtgiokt.Size = new System.Drawing.Size(100, 20);
            this.txtgiokt.TabIndex = 29;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(229, 95);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Giờ bắt đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã ca";
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(96, 63);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(100, 20);
            this.txtmota.TabIndex = 21;
            this.txtmota.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtgiobd
            // 
            this.txtgiobd.Location = new System.Drawing.Point(275, 27);
            this.txtgiobd.Name = "txtgiobd";
            this.txtgiobd.Size = new System.Drawing.Size(100, 20);
            this.txtgiobd.TabIndex = 20;
            // 
            // txtmaca
            // 
            this.txtmaca.Location = new System.Drawing.Point(96, 24);
            this.txtmaca.Multiline = true;
            this.txtmaca.Name = "txtmaca";
            this.txtmaca.Size = new System.Drawing.Size(100, 20);
            this.txtmaca.TabIndex = 19;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(229, 95);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Frm_Ca_hoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 166);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgiokt);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtgiobd);
            this.Controls.Add(this.txtmaca);
            this.Controls.Add(this.btnThem);
            this.Name = "Frm_Ca_hoc";
            this.Text = "Frm_Ca_hoc";
            this.Load += new System.EventHandler(this.Frm_Ca_hoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txttrangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgiokt;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtgiobd;
        private System.Windows.Forms.TextBox txtmaca;
        private System.Windows.Forms.Button btnThem;
    }
}