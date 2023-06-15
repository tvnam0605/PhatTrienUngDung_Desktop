using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using OnTap.DAO;
using OnTap.DTO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
	public partial class Form1 : Form
	{
		BindingSource DSMH = new BindingSource();
		BindingSource DSLoaiHang = new BindingSource();
		public Form1()
		{
			InitializeComponent();
			LoadState();
		}
		void LoadState()
		{
			dgvDSMH.DataSource = DSMH;
			cboLoaiMH.DataSource = DSLoaiHang;

		}
		void LoadDSMH()
		{
			DSMH.DataSource = MatHangDAO.Instance.GetMatHang();

		}
		void LoadDSLH()
		{

			DSLoaiHang.DataSource = LoaiMatHangDAO.Instance.GetLoaiMatHang();
			cboLoaiMH.ValueMember = "TenLoaiHang";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadDSMH();
			LoadDSLH();

		}

		private void dgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaMH.ReadOnly = true;
			int i;
			i = dgvDSMH.CurrentRow.Index;
			txtMaMH.Text = dgvDSMH.Rows[i].Cells[0].Value.ToString();
			txtTenMH.Text = dgvDSMH.Rows[i].Cells[1].Value.ToString();
			cboLoaiMH.Text = dgvDSMH.Rows[i].Cells[2].Value.ToString();
			nudSoLuong.Text = dgvDSMH.Rows[i].Cells[3].Value.ToString();
			nudDonGia.Text = dgvDSMH.Rows[i].Cells[4].Value.ToString();
		}
		private event EventHandler themMatHang;
		public event EventHandler ThemMatHang
		{
			add { themMatHang += value; }
			remove { themMatHang -= value; }
		}
		private event EventHandler suaMatHang;
		public event EventHandler SuaMatHang
		{
			add { suaMatHang += value; }
			remove { suaMatHang -= value; }
		}
		private void btnThemMH_Click(object sender, EventArgs e)
		{
			string TenMatHang = txtTenMH.Text;
			string TenLoaiHang = cboLoaiMH.Text; // Lấy tên loại hàng từ ComboBox

			// Tìm MaLoai tương ứng với TenLoaiHang
			int MaLoai = LoaiMatHangDAO.Instance.GetMaLoaiByTenLoai(TenLoaiHang);

			int SoLuongTon = int.Parse(nudSoLuong.Text);
			float DonGia = float.Parse(nudDonGia.Text);

			if (MatHangDAO.Instance.ThemMatHang(TenMatHang, MaLoai, SoLuongTon, DonGia))
			{
				MessageBox.Show("Thêm mặt hàng thành công");
				LoadDSMH();
				themMatHang?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Thêm mặt hàng không thành công");
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			int MaMatHang = int.Parse(txtMaMH.Text);
			string TenMatHang = txtTenMH.Text;
			string TenLoaiHang = cboLoaiMH.Text; // Lấy tên loại hàng từ ComboBox

			// Tìm MaLoai tương ứng với TenLoaiHang
			int MaLoai = LoaiMatHangDAO.Instance.GetMaLoaiByTenLoai(TenLoaiHang);

			int SoLuongTon = int.Parse(nudSoLuong.Text);
			float DonGia = float.Parse(nudDonGia.Text);

			if (MatHangDAO.Instance.CapNhatMatHang(MaMatHang, TenMatHang, MaLoai, SoLuongTon, DonGia))
			{
				MessageBox.Show("Sửa mặt hàng thành công");
				LoadDSMH();
				suaMatHang?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Sửa mặt hàng không thành công");
			}
		}

		private void btnThemLoai_Click(object sender, EventArgs e)
		{
			var frm = new frmLoaiHangHoa();
			this.Hide();
			frm.ShowDialog();
			LoadDSLH();
			this.Show();
		}
	}
}

