using System.Collections;
using UnityEngine;
using System.Collections;

public class PowerUpManager : MonoBehaviour
{
    /// <summary>
    /// Problem: You are creating a game where the player can collect power-ups.
    /// Each power-up has a different effect on the player, and you want to store the effect of each power-up in an sbyte array.
    /// Write a script that initializes the sbyte array with the effects of three different power-ups.
    /// negatif ve pozitif ancak 128 e kadar olacaklar için bunu kullanabilirim
    /// </summary>
    sbyte[] powerUpEffects = new sbyte[3];

    void Start()
    {
        powerUpEffects[0] = 2; // power-up 1 increases speed by 2
        powerUpEffects[1] = -1; // power-up 2 decreases speed by 1
        powerUpEffects[2] = 3; // power-up 3 increases damage by 3

        Debug.Log("Power-up effects initialized.");
    }
}
