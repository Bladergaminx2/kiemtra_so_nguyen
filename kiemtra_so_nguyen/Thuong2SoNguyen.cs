using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra_so_nguyen
{
    public class Thuong2SoNguyen
    {
        public double ChiaHaiSoNguyen(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Không thể chia cho 0.");
            }

            return (double)a / b;
        }
    }
}
