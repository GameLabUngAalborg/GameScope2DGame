using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour {

    public int AmountOfCoin = 5;

	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            GameObject.Find("ScoreManager").GetComponent<Score>().AddCoin(AmountOfCoin);
            Destroy(gameObject);
        }
    }
}
