using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef02.Model
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId {set; get;}
        public virtual List<Product> products {set; get;}
        
        [StringLength(100)]
        public string Name {set; get;}

        [Column(TypeName="ntext")]                  // Cột (trường) kiểu ntext trong SQL Server
        public string Description {set; get;}
    }
}