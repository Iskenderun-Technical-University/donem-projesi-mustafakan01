using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour,ICoinable
     
{
    public void Coins()
    {
  
        CoinText.cointcount++;
        Debug.Log("caoinpik");
        //CoinText.coinText.cointcount+=1;
        Destroy(gameObject); 
    }

}
