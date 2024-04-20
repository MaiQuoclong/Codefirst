using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    public class SinhVien
    {
        public int SinhVienId { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
    }
}
