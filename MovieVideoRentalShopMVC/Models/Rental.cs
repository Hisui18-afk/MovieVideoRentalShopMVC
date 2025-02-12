using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieVideoRentalShopMVC.Models
{
    public class Rental
    {



        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        [Required]
        public DateOnly RentDate { get; set; }
        [Required]
        public DateOnly ReturnDate { get; set; }
        [Required]

        public ICollection<RentalDetail> RentalDetails { get; set; }




    }

    public class RentalDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RentalHeaderId { get; set; }
        [ForeignKey("RentalHeaderId")]
        public virtual Rental Rental { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }

    }
}
