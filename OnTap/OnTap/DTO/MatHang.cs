using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace OnTap.DTO
{
	public class MatHang
	{
		public int maMatHang;
		public string tenMatHang;
		public string loaiMatHang;
		public int soLuongTon;
		public float donGia;

		public int MaMatHang { get => maMatHang; set => maMatHang = value; }
		public string TenMatHang { get => tenMatHang; set => tenMatHang = value; }
		public string LoaiMatHang { get => loaiMatHang; set => loaiMatHang = value; }
		public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }
		public float DonGia { get => donGia; set => donGia = value; }
		public MatHang(int maMatHang, string tenMatHang, string loaiMatHang, int soLuongTon, float donGia)
		{
			MaMatHang = maMatHang;
			TenMatHang = tenMatHang;
			LoaiMatHang = loaiMatHang;
			SoLuongTon = soLuongTon;
			DonGia = donGia;
		}
		public MatHang(DataRow row)
		{
			MaMatHang = (int)row["MaMatHang"];
			TenMatHang = row["TenMatHang"].ToString();
			LoaiMatHang = row["TenLoaiHang"].ToString() ;
			SoLuongTon = (int)row["SoLuongTon"];
			DonGia = (float)Convert.ToDouble(row["DonGia"]);
		}
	}
}
