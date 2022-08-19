using System.Collections;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;

    public static int Lives;
    public int startLives = 20;

    public static int Rounds;

    void Start ()
    {
        Money = startMoney; 
        Lives = startLives;
        Rounds = 0;
    }

    //consider using life tracker here - Better for larger games
}
