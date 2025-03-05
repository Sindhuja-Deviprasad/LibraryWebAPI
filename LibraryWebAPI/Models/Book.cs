using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace LibraryWebAPI.Models
{
    public class Book
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int BookId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }

        [StringLength(15)]
        public string ISBN { get; set; }
        [Range(1900, 2100)]
        public int YearPulished { get; set; }
        [Required]
        //public int AvailableCopies { get; set; }

        //public Transaction Transaction { get; set; }
        public IList<Transaction> Transactions { get; set; }
    }
}
