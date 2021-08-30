using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.models
{
    public class Book
    {
        [Key]
        
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }
        public string Auther { get; set; }
        public string ISBN { get; set; }
    }
}
