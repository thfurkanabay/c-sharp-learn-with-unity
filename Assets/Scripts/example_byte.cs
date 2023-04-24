using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour
{
    /// <summary>
    ///  problem: You are creating a game where the player can collect coins.
    /// Each coin has a point value, and you want to store the point value of each coin in a byte array.
    /// Write a script that initializes the byte array with the point values of five different types of coins.
    /// </summary>
    /// 
    byte[] coinValues = new byte[5];

    void Start()
    {
        coinValues[0] = 1; // penny is worth 1 point
        coinValues[1] = 5; // nickel is worth 5 points
        coinValues[2] = 10; // dime is worth 10 points
        coinValues[3] = 25; // quarter is worth 25 points
        coinValues[4] = 50; // golden coin is worth 50 points
        // coinValues[5] = 300; // golden coin is worth 50 points byte --> 0 to 255	

        Debug.Log("Coin values initialized.");
    }
}