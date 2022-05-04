using Spriter2UnityDX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class enemyScrpit : MonoBehaviour
{
    public float health, armor,helmetarmor,damage, lastFired, fireRate, lastFiredforSoldier,speed;
    public float opacity;
    public int award,orderinlayer;
    public GameManagager gm;
    public bool awardTake, deathAnimation, stop, rangeFire, Fire, death, control = false, control2 = false,slow=false;
    public EnemyType enemyType;
    public int randomNumber;
    public AudioSource audioSource;
    private Component[] boxColliders;
    public GameObject bar,healthBar;
    private float fullhealth,localscalex;
    
  
    







    void Start()
    {
        speed = enemyType.speed;

         localscalex = healthBar.transform.localScale.x;
        gm = GetComponentInParent<GameManagager>();
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        boxColliders = GetComponentsInChildren<BoxCollider2D>();

        health = enemyType.health;
        armor = enemyType.armor;
        helmetarmor =enemyType.helmetarmor;
        damage = enemyType.damage;
        fireRate = enemyType.fireRate;
        award = enemyType.award;
        awardTake = false;
        opacity = 1;
        stop = false;
        rangeFire = false;
        Fire = false;
        death = false;
        fullhealth = health;
      
    }

    private void Update()
    {
        healthBar.transform.localScale = new Vector3((health / fullhealth * localscalex), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
        if (health <= 0 )
        {
            health = 0;
            if (!awardTake)
            {
                gm.money += award;
                gm.currentEnemyCount--;
            }
            
            awardTake = true;
            deathAnimation = true;
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponentInChildren<Animator>().SetBool("isDeath", true);
            gameObject.tag = ("Died");



        }
        if (control2)
        {
            gm.enemyCurrentHelth -= (fullhealth - health);
            control2 = false;
        }


        
        if(health < fullhealth && !control)
        {
            bar.gameObject.SetActive(true);
            healthBar.gameObject.SetActive(true);
            control = true;
        }

        if (slow&&health>0&&!Fire && !rangeFire)
        {
            slow = false;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed - (speed * 15 / 100), 0);
            StartCoroutine(Speed(3.5f));
        }



        if (deathAnimation)
        {

            GetComponentInChildren<EntityRenderer>().Color = new Color(255, 255, 255, opacity);
            if(!death)
            {
                death = true;
                for (int i = 0; i < boxColliders.Length; i++)
                {
                    Destroy(boxColliders[i]);
                  
                }
              
            }
           
            opacity -= 0.75f * Time.deltaTime;
            if (opacity <= 0.75f)
            {
                bar.SetActive(false);
                healthBar.SetActive(false);
            }
            
            if (opacity <= 0.25f)
                Destroy(gameObject);
        }











        if (rangeFire && (health > 0))
        {
            if (!stop)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

               
            }
            stop = true;

            GetComponentInChildren<Animator>().SetBool("isFire", true);
          
        }



        if (Fire && (health > 0))
        {

            if (!stop)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
            stop = true;

            GetComponentInChildren<Animator>().SetBool("isFire", true);
            if ((Time.realtimeSinceStartup - lastFired > fireRate) && !gm.isDied && !rangeFire&&Time.timeScale>=1&&gm.currentHealth>0)
            {
                lastFired = Time.realtimeSinceStartup;
                gm.currentHealth -= damage;

            }
        }

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

        
        if (collision.gameObject.tag == "RangeWall" && enemyType.range)

        {
            rangeFire = true;
         
        }

        else if (collision.gameObject.tag == "Wall")

        {
            Fire = true;


        }

        
    }


    IEnumerator Speed(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        GetComponent<Rigidbody2D>().velocity = new Vector2(enemyType.speed, 0);

    }

    public void PlaySound() 
    {
        audioSource.Play();
    }
   
    
   
}
