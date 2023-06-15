using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.DTO
{
	public class LoaiMatHang
	{
		public int maLoaiHang;
		public string tenLoaiHang;
		public int MaLoai { get => maLoaiHang; set => maLoaiHang = value; }
		public string TenLoaiHang { get => tenLoaiHang; set => tenLoaiHang = value; }
		public LoaiMatHang(int maLoaiHang, string tenLoaiHang)
		{
			MaLoai = maLoaiHang;
			TenLoaiHang = tenLoaiHang;
		}

		public LoaiMatHang(DataRow row)
		{
			MaLoai = (int)row["MaHang"];
			TenLoaiHang = row["TenLoaiHang"].ToString();
		}

	}

}


