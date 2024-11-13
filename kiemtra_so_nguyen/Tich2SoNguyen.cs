using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra_so_nguyen
{
    public class TestTich2SoNguyen
    {
        public double NhanHaiSoNguyen(int a, int b)
        {

            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new ArgumentException("Cả a và b phải là số nguyên.");
            }

            double ketQua = a * b;
            return ketQua;
        }
    }
}
