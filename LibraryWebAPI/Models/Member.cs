using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace LibraryWebAPI.Models
{
    public class Member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Required]
        [StringLength(100)]
        public string MemberName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public long PhoneNo { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string MembershipStatus { get; set; }

        public IList<Transaction> Transactions { get; set; }

        public IList<Notifications> notifications { get; set; }

        public IList<OverdueAndFines> fines { get; set; }
    }
}
