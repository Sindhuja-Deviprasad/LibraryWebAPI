using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebAPI.Models
{
    public class OverdueAndFines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FineId { get; set; }

        //public int MemberId { get; set;}

        Member Member { get; set; }
        public int MemberID { get; set; }

        public int Amount { get; set; }

        public string AmtStatus { get; set; }
    }
}
