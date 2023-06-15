namespace OnTap
{
	partial class Form1
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
			this.dgvDSMH = new System.Windows.Forms.DataGridView();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnThemMH = new System.Windows.Forms.Button();
			this.btnThemLoai = new System.Windows.Forms.Button();
			this.nudDonGia = new System.Windows.Forms.NumericUpDown();
			this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
			this.cboLoaiMH = new System.Windows.Forms.ComboBox();
			this.txtTenMH = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.txtMaMH = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvDSMH
			// 
			this.dgvDSMH.BackgroundColor = System.Drawing.Color.White;
			this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSMH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDSMH.Location = new System.Drawing.Point(3, 16);
			this.dgvDSMH.Name = "dgvDSMH";
			this.dgvDSMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSMH.Size = new System.Drawing.Size(558, 159);
			this.dgvDSMH.TabIndex = 0;
			this.dgvDSMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellContentClick);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Location = new System.Drawing.Point(373, 160);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(72, 21);
			this.btnCapNhat.TabIndex = 5;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnThemMH
			// 
			this.btnThemMH.Location = new System.Drawing.Point(283, 160);
			this.btnThemMH.Name = "btnThemMH";
			this.btnThemMH.Size = new System.Drawing.Size(72, 21);
			this.btnThemMH.TabIndex = 5;
			this.btnThemMH.Text = "Thêm";
			this.btnThemMH.UseVisualStyleBackColor = true;
			this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
			// 
			// btnThemLoai
			// 
			this.btnThemLoai.Location = new System.Drawing.Point(472, 73);
			this.btnThemLoai.Name = "btnThemLoai";
			this.btnThemLoai.Size = new System.Drawing.Size(75, 23);
			this.btnThemLoai.TabIndex = 4;
			this.btnThemLoai.Text = "Thêm loại";
			this.btnThemLoai.UseVisualStyleBackColor = true;
			this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
			// 
			// nudDonGia
			// 
			this.nudDonGia.Location = new System.Drawing.Point(106, 126);
			this.nudDonGia.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.nudDonGia.Name = "nudDonGia";
			this.nudDonGia.Size = new System.Drawing.Size(339, 20);
			this.nudDonGia.TabIndex = 3;
			this.nudDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudDonGia.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			// 
			// nudSoLuong
			// 
			this.nudSoLuong.Location = new System.Drawing.Point(106, 100);
			this.nudSoLuong.Name = "nudSoLuong";
			this.nudSoLuong.Size = new System.Drawing.Size(339, 20);
			this.nudSoLuong.TabIndex = 3;
			this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// cboLoaiMH
			// 
			this.cboLoaiMH.FormattingEnabled = true;
			this.cboLoaiMH.Location = new System.Drawing.Point(106, 73);
			this.cboLoaiMH.Name = "cboLoaiMH";
			this.cboLoaiMH.Size = new System.Drawing.Size(339, 21);
			this.cboLoaiMH.TabIndex = 2;
//			this.cboLoaiMH.SelectedIndexChanged += new System.EventHandler(this.cboLoaiMH_SelectedIndexChanged);
			// 
			// txtTenMH
			// 
			this.txtTenMH.Location = new System.Drawing.Point(106, 47);
			this.txtTenMH.Name = "txtTenMH";
			this.txtTenMH.Size = new System.Drawing.Size(339, 20);
			this.txtTenMH.TabIndex = 1;
			// 
			// txtMaMH
			// 
			this.txtMaMH.Location = new System.Drawing.Point(106, 20);
			this.txtMaMH.Name = "txtMaMH";
			this.txtMaMH.Size = new System.Drawing.Size(339, 20);
			this.txtMaMH.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số lượng";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Loại mặt hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên mặt hàng";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã mặt hàng";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvDSMH);
			this.groupBox2.Location = new System.Drawing.Point(118, 233);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(564, 178);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách mặt hàng";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Đơn giá";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCapNhat);
			this.groupBox1.Controls.Add(this.btnThemMH);
			this.groupBox1.Controls.Add(this.btnThemLoai);
			this.groupBox1.Controls.Add(this.nudDonGia);
			this.groupBox1.Controls.Add(this.nudSoLuong);
			this.groupBox1.Controls.Add(this.cboLoaiMH);
			this.groupBox1.Controls.Add(this.txtTenMH);
			this.groupBox1.Controls.Add(this.txtMaMH);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(118, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(564, 187);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết mặt hàng";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDSMH;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnThemMH;
		private System.Windows.Forms.Button btnThemLoai;
		private System.Windows.Forms.NumericUpDown nudDonGia;
		private System.Windows.Forms.NumericUpDown nudSoLuong;
		private System.Windows.Forms.ComboBox cboLoaiMH;
		private System.Windows.Forms.TextBox txtTenMH;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox txtMaMH;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

