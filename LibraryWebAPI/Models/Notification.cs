using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebAPI.Models
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificationId { get; set; }

        public Member Member { get; set; }
        public int MemberId { get; set; }

        public string Message { get; set; }
        public DateOnly DateSent { get; set; }
    }
}
