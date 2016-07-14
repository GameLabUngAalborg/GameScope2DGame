using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

    public GameObject LevelPanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
    {

        if(other.tag == "Player")
        {
            LevelPanel.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }
	
	}
}
