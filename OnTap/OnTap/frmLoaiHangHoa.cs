using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using OnTap.DAO;
using OnTap.DTO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
	public partial class frmLoaiHangHoa : Form
	{
		BindingSource DSLoaiHang = new BindingSource();
		public frmLoaiHangHoa()
		{
			InitializeComponent();
			LoadState();
		}
		void LoadState()
		{
			dgvDSLoaiHang.DataSource = DSLoaiHang;

		}
		void LoadDSMH()
		{
			DSLoaiHang.DataSource = LoaiMatHangDAO.Instance.GetLoaiMatHang();

		}
		private void frmLoaiHangHoa_Load(object sender, EventArgs e)
		{
			LoadDSMH();
		}

		private void dgvDSLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		private event EventHandler themLoaiMatHang;
		public event EventHandler ThemLoaiMatHang
		{
			add { themLoaiMatHang += value; }
			remove { themLoaiMatHang -= value; }
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (txtTenLoai.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên loại hàng");
			}
			else
			{
				string TenLoaiHang = txtTenLoai.Text;
				if (LoaiMatHangDAO.Instance.ThemLoaiMatHang(TenLoaiHang))
				{
					MessageBox.Show("Thêm loại mặt hàng thành công");
					LoadDSMH();
					themLoaiMatHang?.Invoke(this, new EventArgs());
				}
				else
				{
					MessageBox.Show("Thêm loại mặt hàng không thành công");
				}
			}
			
		}
	}
}
