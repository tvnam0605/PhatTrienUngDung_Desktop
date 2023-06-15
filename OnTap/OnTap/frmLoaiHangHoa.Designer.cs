namespace OnTap
{
	partial class frmLoaiHangHoa
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvDSLoaiHang = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenLoai = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiHang)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 30);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 303);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtTenLoai);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(255, 84);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin loại hàng";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvDSLoaiHang);
			this.groupBox2.Location = new System.Drawing.Point(3, 93);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(255, 210);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách loại hàng";
			// 
			// dgvDSLoaiHang
			// 
			this.dgvDSLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDSLoaiHang.Location = new System.Drawing.Point(6, 19);
			this.dgvDSLoaiHang.Name = "dgvDSLoaiHang";
			this.dgvDSLoaiHang.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvDSLoaiHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDSLoaiHang.Size = new System.Drawing.Size(243, 174);
			this.dgvDSLoaiHang.TabIndex = 0;
			this.dgvDSLoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoaiHang_CellContentClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Loại hàng";
			// 
			// txtTenLoai
			// 
			this.txtTenLoai.Location = new System.Drawing.Point(88, 20);
			this.txtTenLoai.Name = "txtTenLoai";
			this.txtTenLoai.Size = new System.Drawing.Size(80, 20);
			this.txtTenLoai.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(195, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Thêm loại hàng";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmLoaiHangHoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 345);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "frmLoaiHangHoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLoaiHangHoa";
			this.Load += new System.EventHandler(this.frmLoaiHangHoa_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiHang)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvDSLoaiHang;
		private System.Windows.Forms.TextBox txtTenLoai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
	}
}