using DigicallTest.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigicallTest.Data
{
    public class VehicleDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public VehicleDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Vehicle>();
        }

        public Vehicle GetVehicle()
        {
            lock (locker)
            {
                if (database.Table<Vehicle>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<Vehicle>().First();
                }
            }
        }

        public int SaveVehicle(Vehicle vehicle)
        {
            lock (locker)
            {
                if (vehicle.Make != "")
                {
                    database.Update(vehicle);
                    return database.Table<Vehicle>().Count();
                }
                else
                {
                    return database.Insert(vehicle);
                }
            }
        }

        public int DeleteVehicle(int id)
        {
            lock (locker)
            {
                return database.Delete<Vehicle>(id);
            }
        }
    }
}
