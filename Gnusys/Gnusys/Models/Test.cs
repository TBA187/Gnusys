using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gnusys.Models
{
    public class Test
    {
        [Required(ErrorMessage = "Name skal udfyldes!")]
        public string Name { get; set; }
    }
}