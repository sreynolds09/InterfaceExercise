using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car
            {
                Make = "Honda",
                Model = "Civic",
                NumberOfWheels = 4,
                HasTrunk = true,
                IsElectric = false,
                IsDriveable = true,
                NumberOfDoors = 4,
                ManufacturerName = "Honda",
                CompanyLocation = "Tokyo, Japan"
            };

            var myTruck = new Truck
            {
                Make = "Ford",
                Model = "F-150",
                NumberOfWheels = 4,
                HasFlatBed = true,
                WheelSize = 16.5,
                IsDriveable = true,
                ManufacturerName = "Ford",
                CompanyLocation = "Detroit, USA"
            };

            var mySUV = new SUV
            {
                Make = "Toyota",
                Model = "Highlander",
                NumberOfWheels = 4,
                HasFourWheelDrive = true,
                NumberOfRows = 3,
                IsDriveable = true,
                ManufacturerName = "Toyota",
                CompanyLocation = "Japan"
            };

            // Display organized output
            myCar.DisplayDetails();
            myTruck.DisplayDetails();
            mySUV.DisplayDetails();
        }
    }
            }
            
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV

            //DONE - In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //DONE - In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        
