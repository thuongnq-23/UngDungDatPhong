
namespace Quan_Ly_Phong_Hoc.Module
{
    partial class FrmDuyetPhong
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
            this.View1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDat = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.View1)).BeginInit();
            this.SuspendLayout();
            // 
            // View1
            // 
            this.View1.AllowUserToAddRows = false;
            this.View1.BackgroundColor = System.Drawing.Color.White;
            this.View1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column2,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column3,
            this.Column6,
            this.Column1,
            this.btnDat});
            this.View1.EnableHeadersVisualStyles = false;
            this.View1.Location = new System.Drawing.Point(3, 67);
            this.View1.Name = "View1";
            this.View1.RowHeadersVisible = false;
            this.View1.Size = new System.Drawing.Size(906, 329);
            this.View1.TabIndex = 7;
            this.View1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Maphong";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên phòng";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tên Giáo Viên";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ngày dùng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ca học";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giờ bắt đầu";
            this.Column9.Name = "Column9";
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Giờ kết thúc";
            this.Column10.Name = "Column10";
            this.Column10.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại phòng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 85;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vị trí";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mục đích";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // btnDat
            // 
            this.btnDat.HeaderText = "Hành động";
            this.btnDat.Name = "btnDat";
            this.btnDat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDat.Text = "Thực hiện";
            this.btnDat.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập mã giáo viên:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDuyetPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.View1);
            this.Name = "FrmDuyetPhong";
            this.Text = "FrmDuyetPhong";
            this.Load += new System.EventHandler(this.FrmDuyetPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView View1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn btnDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}