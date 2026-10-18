using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MgrUKWShop2.Models
{
    public class Film
    {
        public int Id { get; set; }

        //public int FilmId { get; set; }

        //[Key]
        //public int DowolnaNazwa { get; set; }

        [Required(ErrorMessage = "Podaj tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }

        [StringLength(5000, ErrorMessage = "Limit to 5000 znaków")]
        public string Desc { get; set; }

        public decimal Price { get; set; }

        public DateTime DateAdded { get; set; }

        // nazwa tabeli dołączanej + Id
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        // nazwa tabeli dołączanej + nazwa PK


    }
}
