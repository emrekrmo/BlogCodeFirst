using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual List<Article> TagArticles { get; set; }
    }
}
