using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using VehicleWithGeneric.Entities;

namespace VehicleWithGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                DoTask();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many operation would you like to perform?");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<count; i++)
            {
                Console.WriteLine("Enter type of operation\nHint \nTwoWheeler -1\nFourWheeler -2 ");
                int operationType = Convert.ToInt32(Console.ReadLine());
                if (operationType == 1)
                {
                    GetMotorCycleInfo();
                }
                else if (operationType == 2)
                {
                    GetcarInfo();
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }
            }
            
        }

        private static void GetcarInfo()
        {
            Car<Vehicle> car = new Car<Vehicle>("maruti", 1990, 5, 800, VehicleType.Personal, 4, 4);
            car.GetDetails();
            car.GetDesign();
            string[] designs = car.GetInteriordesins<Vehicle>("TissueBox,AirFreshener, Pillow");
          for(int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine((i+1).ToString()+" " + designs[i]);
            }
        }

        private static void GetMotorCycleInfo()
        {
            MotorCycle<Vehicle> cycle = new MotorCycle<Vehicle>("Yamaha", 2022, 5, 149, VehicleType.Personal, 14.8, 27.5, 40,"disk","disk");
            cycle.GetDetails();
            cycle.Start();
            cycle.cooling();
            string[] designs = cycle.GetExteriorDesigns<Vehicle>("Sticker, LightHorn, FoggLight");
            for (int i = 0; i < designs.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + " " + designs[i]);
            }
        }
    }
}
