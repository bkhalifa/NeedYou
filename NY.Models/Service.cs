using System.ComponentModel.DataAnnotations.Schema;

namespace NY.Models
{

    [Table("Services", Schema = "ref")]
   public  class Service
    {
        public long Id { get; set; }
        public string Libelle { get; set; }

        [ForeignKey("CategoryId")]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
