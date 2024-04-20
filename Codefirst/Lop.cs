using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    public class Lop
    {
        public int LopId { get; set; }
        public string TenLop { get; set; }
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
    }
}
