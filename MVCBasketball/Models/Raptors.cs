using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasketball.Models
{
    public class Raptors
    {

        public int Id { get; set; }
        public int PlayerNumber { get; set; }
        public string PlayerName { get; set; }
        public string PlayerPosition { get; set; }
        public string PlayerHeight { get; set; }
        public double PlayerSalary { get; set; }
    }
}
