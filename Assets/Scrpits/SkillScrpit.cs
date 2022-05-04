using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillScrpit : MonoBehaviour
{
    public GameObject Explosion;
    public Rigidbody2D rb;
    public enemyScrpit enemyScrpit;
    public Vector3 pos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        pos = new Vector3(4.8f, -0.5f, 0);
        var dir = Camera.main.WorldToScreenPoint(pos) - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rb.AddForce(transform.right * 350);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Skill")
        {
            Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);
            enemyScrpit.gm.currentHealth -= enemyScrpit.damage;
            Destroy(gameObject);
            
        
        }
    }
}
