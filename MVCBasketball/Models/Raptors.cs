using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasketball.Models
{
    public class Raptors
    {

        public int Id { get; set; }
        
        [Display(Name ="Player Number")]
        public int PlayerNumber { get; set; }
        [Display(Name ="Player Name")]
        public string PlayerName { get; set; }
        [Display(Name ="Position")]
        public string PlayerPosition { get; set; }
        [Display(Name ="Height")]
        public string PlayerHeight { get; set; }
        [Display(Name = "Salary")]
        [Column(TypeName = "double(18,2)")]
        public double PlayerSalary { get; set; }
    }
}
