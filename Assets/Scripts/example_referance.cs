using System;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Declare a string variable
    private string greeting = "Hello, world!";

    // Declare an object variable
    private object anyObject = 42;

    // Declare a class
    private class Player
    {
        public string name;
        public int health;

        public void Attack()
        {
            Console.WriteLine("Attacking...");
        }
    }

    // Declare an interface
    private interface IWeapon
    {
        void Attack();
    }

    // Declare an enum
    private enum Colors { Red, Green, Blue };

    // Declare a delegate
    private delegate void MyDelegate(string message);

    void Start()
    {
        // Create an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Declare a dynamic variable
        dynamic dynamicVar = 42;

        // Create an instance of the Player class
        Player player = new Player();
        player.name = "John";
        player.health = 100;

    // Implement the IWeapon interface
    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Swinging sword...");
        }
    }

    // Declare and use a delegate
    MyDelegate myDelegate = delegate (string message)
    {
        Console.WriteLine("Delegate says: " + message);
    };
    myDelegate("Hello, delegates!");

    // Print out the values of the variables
    Console.WriteLine(greeting);
    Console.WriteLine(anyObject);
    Console.WriteLine(numbers[2]);
    Console.WriteLine((int)Colors.Green);
    Console.WriteLine(dynamicVar);

    // Call methods of the Player class and Sword class
    player.Attack();
    Sword sword = new Sword();
    sword.Attack();
}
}