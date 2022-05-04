using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScrpit : MonoBehaviour
{


    public float lastFired,fireRate, armorPen;
    public int randomNumber;
    public GameManagager gm;
    public GameObject cArrow, arrow;
    public bool deneme,firstTime;
    public Transform arrowStartPosition;
    public AudioSource audioSource;
    public int  damage, criticalChange;
    void Start()
    {
      
        firstTime = true;
       
        
    }
  

    void Update()
    {
      
       // Debug.Log(gm.enemies.Count);
        if (gm.enemies.Count > 0)
        {
            randomNumber = Random.Range(0, gm.enemies.Count - 1);

            if (Time.realtimeSinceStartup - lastFired > fireRate)
            {

                lastFired = Time.realtimeSinceStartup - Random.Range(0, 0.5f); ;
                cArrow = Instantiate(arrow, arrowStartPosition.transform.position, arrowStartPosition.rotation);
                cArrow.GetComponent<ArrowScrpit>().pos = Camera.main.WorldToScreenPoint(gm.enemies[randomNumber].transform.position); 
                cArrow.GetComponent<ArrowScrpit>().damage = damage;
                cArrow.GetComponent<ArrowScrpit>().armorPen = armorPen;
                cArrow.GetComponent<ArrowScrpit>().criticalChange = criticalChange;
                //audioSource.Play();


            }

        }





    }
   

}
