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



    }
}
