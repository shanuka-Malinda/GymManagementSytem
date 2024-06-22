using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management_System
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int RegFee { get; set; }
        public string Phone { get; set; }
        public string Dob { get; set; }
        public string Date { get; set; }
        
        public int Month { get; set; }

        /////////Delete Table///////////
        ///
        public string TableName { get;set; }
         
    }
}
