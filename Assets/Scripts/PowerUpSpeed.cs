using UnityEngine;
using System.Collections;

public class PowerUpSpeed : MonoBehaviour {

    public float SpeedWhenStarting = 15;
    public float SpeedWhenEnding = 10;
    public float PowerupTime = 2;

    private UnityStandardAssets._2D.PlatformerCharacter2D player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            player = other.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();

            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;

            StartCoroutine(StartThenStop());

        }


    }

    IEnumerator StartThenStop()
    {
        player.m_MaxSpeed = SpeedWhenStarting;
        yield return new WaitForSeconds(PowerupTime);
        player.m_MaxSpeed = SpeedWhenEnding;

    }
}
