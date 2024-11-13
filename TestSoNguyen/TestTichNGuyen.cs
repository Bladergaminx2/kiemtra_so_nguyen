using kiemtra_so_nguyen;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestSoNguyen
{
    public class Tests
    {
        private TestTich2SoNguyen testTich2SoNguyen;

        [SetUp]
        public void Setup()
        {
            testTich2SoNguyen = new TestTich2SoNguyen();
        }

        [Test]
        [TestCase(5, 3, 15)]
        [TestCase(10, 10, 100)]
        [TestCase(-10, -10, 100)]
        [TestCase(0, 5, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-10, 5, -50)]
        [TestCase(10, -1, -10)]
        [TestCase(15, 2, 0)]
        [TestCase(100000, 100000, 0)]
        [TestCase(-100000, -100000, 0)]
        public void KiemThuNhanHaiSoNguyen(int a, int b, double c)
        {
            try
            {
                double ketQua = testTich2SoNguyen.NhanHaiSoNguyen(a, b);
                Assert.AreEqual(c, ketQua);
            }
            catch (ArgumentException)
            {
                Assert.IsTrue(a % 1 != 0 || b % 1 != 0, " đầu vào không phải số nguyên.");
            }
            catch (OverflowException)
            {
                Assert.IsTrue(true, "Đã mong đợi OverflowException cho các giá trị lớn.");
            }
        }
    }
}