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
        for (int i = 0; i <= 10; i++)
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
        int i1 = 0;

        //write while loop here
        while (i1 < n)
        {
            Console.WriteLine(x1);
            i1++;
        }

        //Methods

    }
}
