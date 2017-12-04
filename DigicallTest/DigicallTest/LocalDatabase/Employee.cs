using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigicallTest.LocalDatabase
{
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmpId
        {
            get;
            set;
        }

        public string EmpName
        {
            get;
            set;
        }

        public string Designation
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
