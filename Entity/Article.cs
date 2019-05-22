using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [Required]
        [MaxLength(400)]
        public string Title { get; set; }
        [Column(TypeName ="Text")]
        public string Content { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Category")]//ForeignKey in not must. It is necessary for not having duplicated values
        public int CategoryId { get; set; } //if we want this one null we need to write int? instead od int

        public virtual Category Category { get; set; }
        public virtual List<Tag> Tags { get; set; }

        public Article()
        {
            Date = DateTime.Now;
        }
    }
}
