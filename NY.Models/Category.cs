using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NY.Models
{
    [Table("Categories", Schema = "ref")]
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Libelle { get; set; }
        public string  Comment { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
