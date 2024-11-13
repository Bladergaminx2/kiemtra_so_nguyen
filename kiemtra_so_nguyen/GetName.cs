using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra_so_nguyen
{
    public class GetName
    {
        public string Name { get; set; }
    }
    public class DichVuHoSo
    {
        public string GetName(GetName profile)
        {
            if (profile == null)
            {
                throw new NullReferenceException("Hồ sơ rỗng.");
            }
            return profile.Name;
        }
    }
}
