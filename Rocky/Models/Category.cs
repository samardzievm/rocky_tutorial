﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key] // because I have Id column, even if I write CategoryId, that will be detected as PK. But, if you want a PK, but the prop name doesnt contain Id, you should include [Key]
        public int Id { get; set; }
        [Required] // section 3 - 1
        public string Name { get; set; }
        [DisplayName("Display Order")] // section 2 - 12 (whatever we write here, will be displayed in the view block, ex: DisplayOrder -> Display Order)
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Display order for category must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
