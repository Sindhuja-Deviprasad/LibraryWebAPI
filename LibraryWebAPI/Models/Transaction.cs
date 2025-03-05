using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebAPI.Models
{
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionID { get; set; }

        [Required]

        public DateOnly BorrowDate { get; set; }

        [Required]
        public DateOnly ReturnDate { get; set; }

        [Required]
        public bool BookStatus { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("MemberID")]
        public Member Member { get; set; }

        [Required]
        public int MemberID { get; set; }
    }
}
