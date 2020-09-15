using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Superhero_Project.Models
{
    public class Superhero
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}