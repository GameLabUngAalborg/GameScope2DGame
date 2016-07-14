using UnityEngine;
using System.Collections;

public class HealthSlider : MonoBehaviour
{

    public Health PlayerHP;

    private UnityEngine.UI.Slider Slider;

    private float PlayerStartHealth;

	// Use this for initialization
	void Start () {

        Slider = GetComponent<UnityEngine.UI.Slider>();
        PlayerStartHealth = PlayerHP.CurrentHealth;
        //Slider.maxValue = PlayerStartHealth;

    }
	
	// Update is called once per frame
	void Update () {

        Slider.value = (float)PlayerHP.CurrentHealth / PlayerStartHealth;
	
	}
}
