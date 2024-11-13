using System.Collections.Generic;
using kiemtra_so_nguyen;
using NUnit.Framework;

namespace TestSoNguyen
{
    public class DịchVuHoSoTests
    {
        private DichVuHoSo dichVuHoSo;

        [SetUp]
        public void Setup()
        {
            dichVuHoSo = new DichVuHoSo();
        }

        [Test]
        public void GetName_HoSoRong_ThrowNullReferenceException()
        {
            Assert.Throws<NullReferenceException>(() => dichVuHoSo.GetName(null));
        }

        [Test]
        public void GetName_HoSoKhongRong_Return()
        {
            var profile = new GetName { Name = "Nguyen" };
            Assert.AreEqual("Nguyen", dichVuHoSo.GetName(profile));
        }
    }
}
