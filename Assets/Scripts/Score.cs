using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

    private UnityEngine.UI.Text ScoreText;

    public int CoinsPickedUp = 0;

	void Start()
    {
        ScoreText = GetComponent<UnityEngine.UI.Text>();
    }
	// Update is called once per frame
	void Update ()
    {

        ScoreText.text = "Coins: "+CoinsPickedUp;


    }

    public void AddCoin(int amount)
    {
        CoinsPickedUp += amount;
    }

   
}
