using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    public class Khoa
    {
        public int KhoaId { get; set; }
        public string TenKhoa { get; set; }
        public List<SinhVien> SinhViens { get; set; }
        public List<Lop> Lops { get; set; }
    }
}
