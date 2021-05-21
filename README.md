# DesignParkingSystemTestProject
This application takes a user's input for a number of assigned parking spaces per type of car (Big = 1, Medium = 2, Small = 3). 
This is initialized in the car's constructor when instantiating the class object called ParkingSystem.
However, the user then calls the method called AddCar and in it, they specify the car type (1, 2, or 3) and the method will return a true or false statement; true being that there are enough parking spaces for that car type left, or false, that there aren't.


## Examples
In the environment, let's instantiate the class as so;

            var parkingSystem = new ParkingSystem(2, 1, 3);

Next, let's add some car types to parking spaces and see what is returned.

            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(1));

Hit the run button, and now we will see all statements will be True.

However, if we were to instantiate the class like this:

            var parkingSystem = new ParkingSystem(0, 1, 3);

and ran the same code as before


            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(1));
            
we would see the results as follows: 

            False, True, True, False.

## Prerequisites

### What you'll need to run the code:

* Internet connection

* Visual Studio 2012 v 11.0

* MS SQL Server 2012 v 11.0

### Download the latest versions:

https://visualstudio.microsoft.com/downloads/

https://www.microsoft.com/en-us/sql-server/sql-server-downloads# 
