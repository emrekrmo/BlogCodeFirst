using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [MaxLength(100)] //nvarchar(100)
        public string Name { get; set; }
        [ForeignKey("ParentCategory")]
        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }
        public virtual List<Category> SubCategories { get; set; }
        public virtual List<Article> Articles { get; set; }
    }    
}
