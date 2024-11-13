using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using kiemtra_so_nguyen;

namespace TestSoNguyen
{
    public class TinhToanTests
    {
        private Thuong2SoNguyen thuong2SoNguyen;

        [SetUp]
        public void Setup()
        {
            thuong2SoNguyen= new Thuong2SoNguyen();
        }



        [Test]
        [TestCase(10, 2, 5)]           
        [TestCase(-10, 2, -5)]           
        [TestCase(10, -2, -5)]           
        [TestCase(-10, -2, 5)]           
        [TestCase(0, 5, 0)]              
        [TestCase(0, -5, 0)]             
        [TestCase(int.MaxValue, 1, int.MaxValue)]  
        [TestCase(int.MinValue, -1, int.MaxValue)] 
        [TestCase(10, 0, 0)]            
        [TestCase(100, 10, 10)]         
        public void KiemThuChiaHaiSoNguyen(int a, int b, double expected)
        {
            if (b == 0)
            {
                Assert.Throws<DivideByZeroException>(() => thuong2SoNguyen.ChiaHaiSoNguyen(a, b), "Không thể chia cho 0.");
            }
            else
            {
                double ketQua = thuong2SoNguyen.ChiaHaiSoNguyen(a, b);
                Assert.AreEqual(expected, ketQua, 1e-9, "Kết quả chia không chính xác.");
            }
        }
    }
}
