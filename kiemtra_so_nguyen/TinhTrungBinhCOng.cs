using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra_so_nguyen
{
    public class TinhTrungBinhCong
    {
        public double TrungBinhCong(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArithmeticException("Danh sách rỗng");
            }

            return numbers.Average();
        }
    }
}
