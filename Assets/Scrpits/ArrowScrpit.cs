using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScrpit : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public Transform enemy;
    public int speed,damage, criticalChange;
    public float armorPen;
    public Vector3 pos;
    public GameObject fire;
    public bool slow;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


        
        var dir = pos - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.AddForce(transform.right * 350);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            Destroy(gameObject);
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Head")
        {
            Destroy(gameObject);
            if (Random.Range(0, 100)+criticalChange >= 100)

            {
                collision.gameObject.GetComponentInParent<enemyScrpit>().health -= 2 * (damage - (collision.gameObject.GetComponentInParent<enemyScrpit>().helmetarmor - armorPen) * damage / 100);
                Debug.Log("Critic!!");
            }
            else
            {
                collision.gameObject.GetComponentInParent<enemyScrpit>().health -= (damage - (collision.gameObject.GetComponentInParent<enemyScrpit>().helmetarmor - armorPen) * damage / 100);

            }
            Instantiate(fire, transform.position, transform.rotation);
            collision.gameObject.GetComponentInParent<enemyScrpit>().control2 = true;
            if(slow)
            {
                collision.gameObject.GetComponentInParent<enemyScrpit>().slow =true;

            }



        }
        else if (collision.gameObject.name == "Body")
        {
            Destroy(gameObject);
            if (Random.Range(0, 100) + criticalChange >= 100)

            {
                collision.gameObject.GetComponentInParent<enemyScrpit>().health -= 2*(damage - (collision.gameObject.GetComponentInParent<enemyScrpit>().armor - armorPen) * damage / 100);
                Debug.Log("Critic!!");
            }
            else
            {
                collision.gameObject.GetComponentInParent<enemyScrpit>().health -= (damage - (collision.gameObject.GetComponentInParent<enemyScrpit>().armor - armorPen) * damage / 100);

            }
            Instantiate(fire, transform.position, transform.rotation);
            collision.gameObject.GetComponentInParent<enemyScrpit>().control2 = true;


        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);

        }
    }
}
