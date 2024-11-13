using NUnit.Framework;
using kiemtra_so_nguyen;
using System.Collections.Generic;

namespace TestSoNguyen
{
    public class TestTrungBinhCong
    {
        private TinhTrungBinhCong tinhTrungBinhCong;

        [SetUp]
        public void Setup()
        {
            tinhTrungBinhCong = new TinhTrungBinhCong();
        }

        [Test]
        public void KiemThuTrungBinhCong_KhiDanhSachRong()
        {
            Assert.Throws<ArithmeticException>(() => tinhTrungBinhCong.TrungBinhCong(new List<int>()), "Danh sách rỗng, không thể tính");
        }

        [Test]
        public void KiemThuTrungBinhCong_DanhSachMotPhanTu()
        {
            double ketQua = tinhTrungBinhCong.TrungBinhCong(new List<int> { 10 });
            Assert.AreEqual(10, ketQua);
        }

        [Test]
        public void KiemThuTrungBinhCong_DanhSachNhieuPhanTuDuong()
        {
            double ketQua = tinhTrungBinhCong.TrungBinhCong(new List<int> { 2, 4, 6, 8 });
            Assert.AreEqual(5, ketQua);
        }

        [Test]
        public void KiemThuTrungBinhCong_DanhSachNhieuPhanTuAm()
        {
            double ketQua = tinhTrungBinhCong.TrungBinhCong(new List<int> { -2, -4, -6, -8 });
            Assert.AreEqual(-5, ketQua);
        }

        [Test]
        public void KiemThuTrungBinhCong_DanhSachPhanTuDuongVaAm()
        {
            double ketQua = tinhTrungBinhCong.TrungBinhCong(new List<int> { -3, 3 });
            Assert.AreEqual(0, ketQua);
        }
    }
}
