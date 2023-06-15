using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using OnTap.DTO;
using System.Threading.Tasks;

namespace OnTap.DAO
{
	public class LoaiMatHangDAO
	{
		private static LoaiMatHangDAO _instance;
		public static LoaiMatHangDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new LoaiMatHangDAO();
				}
				return _instance;
			}

		}
		private LoaiMatHangDAO(){}
		public List<LoaiMatHang> GetLoaiMatHang()
		{
			List<LoaiMatHang> lhh = new List<LoaiMatHang>();
			string query = "select * from LoaiMatHang";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in table.Rows)
			{
				lhh.Add(new LoaiMatHang(row));
			}
			return lhh;
		}
		public int GetMaLoaiByTenLoai(string tenLoai)
		{
			string query = "SELECT MaHang FROM LoaiMatHang WHERE TenLoaiHang = @TenLoai";
			object result = DataProvider.Instance.ExecuteScalar(query, new object[] { tenLoai });
			if (result != null && int.TryParse(result.ToString(), out int maLoai))
			{
				return maLoai;
			}
			return -1;
		}
		
		public bool ThemLoaiMatHang(string tenLoaiHang)
		{
			string query = "exec USP_ThemLoaiHang @TenLoaiHang ";
			object[] param = new object[] { tenLoaiHang };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

	}
}
