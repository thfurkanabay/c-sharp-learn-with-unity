using UnityEngine;
using System.Collections;

public class CoinCollector : MonoBehaviour
{
    short totalCoinValue = 0;
/// <summary>
/// **Problem**: You are creating a game where the player can collect coins of different denominations.
/// You want to keep track of the total value of the coins collected by the player,
/// and you decide to store this value in a "short" data type to save memory.
/// Write a script that initializes a "short" variable with the value of 0,
/// and adds the value of three different coins to the variable.
/// </summary>
    void Start()
    {
        short coin1Value = 5;
        short coin2Value = 10;
        short coin3Value = 2;

        totalCoinValue += coin1Value;
        totalCoinValue += coin2Value;
        totalCoinValue += coin3Value;

        Debug.Log("Total coin value: " + totalCoinValue);
    }
}