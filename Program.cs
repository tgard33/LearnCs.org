using System;

public class Tutorial
{
    public static void Main()
    {
        //Variables and Types Exercise

        //Define three variables:
        //a string named productname equal to tv.
        //an integer named productyear equal to 2012.
        //a float named productprice equal to 279.99f.

        // write your code here
        string productName = "TV";
        int productYear = 2012;
        float productPrice = 279.99f;
        // test code
        Console.WriteLine("productName: " + productName);
        Console.WriteLine("productYear: " + productYear);
        Console.WriteLine("productPrice: " + productPrice);



        //Type Conversion Exercise

        //Convert myDBL to int and print it.
        double myDBL = 99.0;
        myDBL = Convert.ToInt32(99.0);
        Console.WriteLine(myDBL);

        //Conditionals

        //In this exercise, you must construct an if statement that checks if the number guess is equal to 500.
        //If that is the case, use Console.WriteLine to display "Success!".
        int guess = 500;

        // Write conditional here
        if (guess == 500)
        {
            Console.WriteLine("Success!");
        }
        else
            Console.WriteLine("false");

        //Arrays

        //Define an array called fruits that holds the following strings: "apple", "banana", and "orange".

        // write your code here
        string[] fruits = { "apple", "banana", "orange" };
        // test code
        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits[1]);
        Console.WriteLine(fruits[2]);

        //Difference Between Lists and Arrays:
        //The difference between a list and an array is that lists are dynamic sized, while arrays have a fixed size.
        //When you do not know the amount of variables your array should hold, use a list instead.

        //Lists

        //Construct a list of the first 5 prime numbers(2, 3, 5, 7, 11) called primeNumbers.

        // TODO: add your code here
        List<int> primeNumbers = new List<int>{ 2, 3, 5, 7, 11 };
        // test code
        Console.WriteLine(primeNumbers.Count);
        Console.WriteLine(primeNumbers[0]);
        Console.WriteLine(primeNumbers[1]);
        Console.WriteLine(primeNumbers[2]);
        Console.WriteLine(primeNumbers[3]);
        Console.WriteLine(primeNumbers[4]);

        //Dictionaries

        //Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
        //Here is the inventory specification:
            //3 of type apple
            //5 of type orange
            //2 of type banana
        // TODO: add the inventory dictionary here
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("apple", 3);
        inventory.Add("orange", 5);
        inventory.Add("banana", 2);

        Console.WriteLine(inventory["apple"]);
        Console.WriteLine(inventory["orange"]);
        Console.WriteLine(inventory["banana"]);

        //Strings
        //Use string formatting to format the variables firstName, lastName and age to form the following sentence into the string sentence:

        //John Doe is 27 years old.
        string firstName = "John";
        string lastName = "Doe";
        int age = 27;

        // TODO: change this
        string sentence = $"{firstName} {lastName} is {age} years old";
        string sentenceV2 = String.Format("{0} {1} is {2} years old.", firstName, lastName, age);

        Console.WriteLine(sentence);
        Console.WriteLine(sentenceV2);

        //For Loops
        //For Loop syntax:
        //for( [variable to count iterations] ; [conditions checked for] ; [code to execute every loop])
        //There are several statements you can use to control a loop:
            //break;
            //continue;

        //Print the value of variable X to the screen N number of times

        string x = "Hi";
        int n = 10;

        // write for loop here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(x);
        }

        //Foreach Loops
        //Purpose:
        //A Foreach loop is used for getting items from an array. That makes this process so easier than using a for loop.

        //In this exercise, you must output every item in parts with a foreach loop that has part as a variable.

        string[] parts = { "CPU", "RAM", "HDD", "SSD", "GPU" };
        //Place the loop here (Replace the comment)
        foreach (string part in parts)
        {
            Console.WriteLine(part);    
        }

        //While Loops
        //Print X to the console N time using a while loop
        string x1 = "Hi";
        int n1 = 10;
        

        //write while loop here
        while (n1 > 0)
        {
            Console.WriteLine(x1);
            n1--;
        }

        //Methods
        //Write a method that divides two numbers (provided as parameters). Tip: you will need to use the
        //modifiers public and static.
        int xx = 2;
        int y = 2;
        int a = Foo(xx, y);
        Console.WriteLine(a);

        //Basic Classes
        //Make a class car with the fields numTires = 4, year = 2000, and runs = true, and create 
        //three instances of it: car1, car2, and car3.
        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();
       
        // Test code
        Console.WriteLine(car1.numTires);
        Console.WriteLine(car2.year);
        Console.WriteLine(car3.runs);

        //Class Variables
        //Make a class Vehicle with the fields string Type, int NumTires, int Year, and bool Runs, and create:

        //A car: Type = car with NumTires = 4 from Year = 2000 which Runs = true An oldcar: Type = car with NumTires = 4 from 
        //Year = 1980 which Runs = false A bike: Type = bike with NumTires = 2 from Year = 2017 which Runs = true
        //Watch out for the capitalizations!
        Vehicle car = new Vehicle("Car", 4, 2000, true);
        Vehicle oldcar = new Vehicle("Car", 4, 1980, false);
        Vehicle bike = new Vehicle("bike", 2, 2017, true);

        // Test code
        Console.WriteLine(car.Type);
        Console.WriteLine(oldcar.Runs);
        Console.WriteLine(bike.NumTires);

        //Class Properties
        //Make a class Vehicle with the properties string Type and int NumTires.
        //When Type is set to String.Empty, print "The vehicle type cannot be empty" and keep the previous value.
        //When NumTires is set to a value less than 1, print "The vehicle must have at least one tire" and keep the previous value.
        // Test code
        VehicleV2 myRide = new VehicleV2();
        myRide.Type = "Motorcycle";
        myRide.NumTires = 2;
        Console.WriteLine(myRide.Type);
        Console.WriteLine(myRide.NumTires);
        myRide.Type = String.Empty;
        Console.WriteLine(myRide.Type);
        myRide.NumTires = 0;
        Console.WriteLine(myRide.NumTires);
    }

    //Part of Class Properties Exercise
    public class VehicleV2
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                if (value == String.Empty)
                {
                    Console.WriteLine("The vehicle type cannot be empty");
                }
                else _type = value;
            }
        }

        private int _numTires;
        public int NumTires
        {
            get { return _numTires; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("The vehicle must have at least one tire");
                }
                else _numTires = value;
            }
        }
    }

    //Part of Class Variables Exercise
    public class Vehicle
    {
        public string Type;
        public int NumTires;
        public int year;
        public bool Runs;
        public Vehicle(string type, int numTires, int year, bool runs)
        {
            Type = type;
            NumTires = numTires;
            this.year = year;
            Runs = runs;
        }   
    }

    //Part of Basic Classes Exercise
    public class Car
    {
       public int numTires  = 4;
       public string runs  = "true";
       public int year  = 2000;
       
    }

 
    //Part of Methods Exercise
    public static int Foo(int xx, int y)
    {
        return xx / y;
    }
}


