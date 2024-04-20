using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFContext())
            {
                context.Database.EnsureCreated();

                var sinhviens = NhapDanhSachSinhVien();

                context.SinhViens.AddRange(sinhviens);
                context.SaveChanges();

                var sinhvienList = context.SinhViens
                    .Where(s => s.Khoa.TenKhoa == "CNTT" && s.Tuoi >= 18 && s.Tuoi <= 20)
                    .ToList();

                foreach (var sv in sinhvienList)
                {
                    Console.WriteLine($"ID: {sv.SinhVienId}, Ten: {sv.Ten}, Tuoi: {sv.Tuoi}, Khoa: {sv.Khoa.TenKhoa}");
                }
            }
        }

        static List<SinhVien> NhapDanhSachSinhVien()
        {
            var sinhviens = new List<SinhVien>();

            Console.WriteLine("Nhap danh sach sinh vien:");
            while (true)
            {
                var sinhVien = new SinhVien();

                Console.Write("Nhap ten sinh vien (de trong neu ket thuc): ");
                string ten = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ten))
                    break;

                sinhVien.Ten = ten;

                Console.Write("Nhap tuoi: ");
                if (!int.TryParse(Console.ReadLine(), out int tuoi))
                {
                    Console.WriteLine("Tuoi khong hop le, xin vui long nhap lai.");
                    continue;
                }
                sinhVien.Tuoi = tuoi;

                Console.Write("Nhap ID khoa: ");
                if (!int.TryParse(Console.ReadLine(), out int khoaId))
                {
                    Console.WriteLine("Id khoa khong hop le, xin vui long nhap lai.");
                    continue;
                }
                sinhVien.KhoaId = khoaId;

                sinhviens.Add(sinhVien);
            }

            return sinhviens;
        }
    }
}
