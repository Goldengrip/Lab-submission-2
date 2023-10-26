using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    Collectable coin;

    public void Awake()
    {
        coin = new Collectable("coin",1,0);
    }
    private void OnTriggerEnter(Collider other)
    {
       
       if (other.gameObject.tag == "Player")
       {
            coin.UpdateScore();
           Destroy(gameObject);

       }
    }
}
