using UnityEngine;
using System.Collections;

public class PowerUpJump : MonoBehaviour {

    public float JumpPowerWhenStarting = 1000;
    public float JumpPowerWhenEnding = 800;
    public float PowerupTime = 2;

    private UnityStandardAssets._2D.PlatformerCharacter2D player;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
    {
	
        if(other.tag == "Player")
        {
            player = other.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();

            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            StartCoroutine(StartThenStop());

        }


	}

    IEnumerator StartThenStop()
    {
        player.m_JumpForce = JumpPowerWhenStarting;
        yield return new WaitForSeconds(PowerupTime);
        player.m_JumpForce = JumpPowerWhenEnding;

    }
}
