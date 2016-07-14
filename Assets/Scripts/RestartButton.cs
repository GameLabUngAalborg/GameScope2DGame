using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

    public KeyCode PressThisToRestart = KeyCode.R;

	// Update is called once per frame
	void Update () {
	
        if(Input.GetKeyDown(PressThisToRestart))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }

	}
}
