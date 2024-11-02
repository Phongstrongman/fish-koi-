using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Managerment_fish.Models
{
	public class ChatLuongHoCa
	{
		[Key]
		public int MaChatLuong { get; set; }

		[ForeignKey("NguoiDung")]
		public int MaNguoiDung { get; set; }  

		[Required]
		public float PH { get; set; }

		[Required]
		public float NhietDo { get; set; }

		[Required]
		public float OxyHoaTan { get; set; }

		public float? DoDuc { get; set; }

		public DateTime NgayKiemTra { get; set; } = DateTime.Now;
	}
}
