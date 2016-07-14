using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int CurrentHealth = 3;

    private bool candie = true;

    public void ChangeHealth(int Amount)
    {
        if (candie == true)
        {
            CurrentHealth += Amount;

            if (CurrentHealth <= 0 && candie)
            {

                Destroy(gameObject);
            }
            StartCoroutine(CantDie());
            StartCoroutine(Blink());
        }
    }
	
	// Update is called once per frame
	void Update ()
    {

    
	
	}

    IEnumerator CantDie()
    {
        candie = false;
        yield return new WaitForSeconds(1);
        candie = true;
    }

    IEnumerator Blink()
    {
        SpriteRenderer r = GetComponent<SpriteRenderer>();

        for(int i = 0; i < 10; i++)
        {
            if(r.enabled)
            {
                r.enabled = false;
            }
            else
            {
                r.enabled = true;
            }

            yield return new WaitForSeconds(0.1f);

        }

        r.enabled = true;
        yield break;
    }


    }
