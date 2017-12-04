using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigicallTest.Models
{
    public class Vehicle
    {
        //[PrimaryKey]
        //public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public float Millage { get; set; }

        public Vehicle() { }
        public Vehicle(string Make, string Model, string Year, float Millage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Millage = Millage;
        }

        public bool CheckInformation()
        {
            if (!this.Make.Equals("") && !this.Model.Equals(""))
                return true;
            else
                return false;
        }
    }
}

