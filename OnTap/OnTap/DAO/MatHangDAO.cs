using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnTap.DTO;
using System.Data;
using System.Threading.Tasks;

namespace OnTap.DAO
{
	public class MatHangDAO
	{
		private static MatHangDAO _instance;
		public static MatHangDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new MatHangDAO();
				}
				return _instance;
			}

		}
		private MatHangDAO()
		{

		}
		public List<MatHang> GetMatHang()
		{
			List<MatHang> hh = new List<MatHang>();
			string query = "Exec USP_XemDanhSachMatHang";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				hh.Add(new MatHang(row));
			}
			return hh;
		}
		public bool ThemMatHang(string tenMatHang, int loaiMatHang, int soLuongTon, float donGia)
		{
			string query = "exec USP_ThemMatHang @TenMatHang , @LoaiMatHang , @SoLuongTon , @DonGia ";
			object[] param = new object[] { tenMatHang, loaiMatHang, soLuongTon, donGia };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
		public bool CapNhatMatHang(int MaMatHang,string tenMatHang, int loaiMatHang, int soLuongTon, float donGia)
		{
			string query = "EXEC USP_CapNhatMatHang @MaMatHang , @TenMatHang , @LoaiMatHang , @SoLuongTon , @DonGia";
			object[] param = new object[] { MaMatHang, tenMatHang, loaiMatHang, soLuongTon, donGia };

			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	

	}
}
