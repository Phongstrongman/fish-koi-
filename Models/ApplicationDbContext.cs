using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Managerment_fish.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<NguoiDung> NguoiDung { get; set; }

		public DbSet<ChatLuongHoCa> ChatLuongHoCa { get; set; }
	}


	public class NguoiDung
    {
		[Key]
		public int MaNguoiDung { get; set; } // Primary Key
		public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string VaiTro { get; set; }
        public DateTime NgayTao { get; set; }
    }
}
