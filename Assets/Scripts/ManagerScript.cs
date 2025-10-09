using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    int coins = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CollectCoin()
    {
        coins++;
    }

    // Update is called once per frame
    public int GetCoins(){
        return coins;
    }
}