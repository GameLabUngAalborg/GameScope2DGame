using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public int Damage = 1;
    public float MoveSpeed = 10;
    public GameObject Point1, Point2;

    private Vector3 point1, point2;

    private bool Switch = false;

	// Use this for initialization
	void Start ()
    {
       Point1.transform.parent = null;
        Point2.transform.parent = null;
       

    }

    void Update()
    {
        if (Switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, Point2.transform.position, MoveSpeed * Time.deltaTime);
            if (transform.position == Point2.transform.position)
            {
                Switch = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, Point1.transform.position, MoveSpeed * Time.deltaTime);
            if (transform.position == Point1.transform.position)
            {
                Switch = true;
            }
        }

    }
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D other)
    {
	
        if(other.gameObject.tag == "Player")
        {
            
            //if the player is hitting over half circle
            if(other.transform.FindChild("GroundCheck").transform.position.y > transform.position.y+GetComponent<CircleCollider2D>().offset.y)
            {
                other.transform.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 20, ForceMode2D.Impulse);
                Destroy(gameObject);
            }
            else
            {
                other.gameObject.GetComponent<Health>().ChangeHealth(-Damage);

                if(other.transform.FindChild("GroundCheck").transform.position.x < transform.position.x)
                {
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 20, ForceMode2D.Impulse);
                }
                else
                {
                    other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 20, ForceMode2D.Impulse);
                }

            }


        }


	}
}
