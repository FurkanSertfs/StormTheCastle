using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagager : MonoBehaviour
{
    public AudioClip headshot;
    public int day, money,speed;
    public float currentHealth, Health,fireRate, armorPen,enemyCurrentHelth, currentEnemyCount, lastFired;
    [Space]
    public List<GameObject> enemies = new List<GameObject>();
    [Space]
    public GameObject[] turrets;
    [Space]
    public Transform[] spwnPoints;
    [Space]
    public AudioSourceClass audioSourceC;
    [Space]
    public TextClass textC;
    [Space]
    public GameObjectClass gameObjectC;
    public Image healthImage,enemyCountImage;
    
    public NewResourceManager resourcesManager;
    public bool isDied, nextDay, menuOpen,slow,deletesave;

    private bool isWaitinginMenu;
    private float timer, lastRepaired, repairRate=1;
    public int damage ,tower, criticalChange,dailyEnemyCount;
    public AudioClip firesound, buySound, reloadSound, reloadSound2, reloadSound3, hitsound;
    public Animator anim;
    public GameObject arrow;
    public Transform arrowPosition;
    public bool arrow1Buff, arrow2Buff, arrow3Buff, arrow4Buff, arrow1Control, arrow2Control, arrow3Control, arrow4Control;
    public UprageMenu uprageMenu;
   
   


    [System.Serializable]
    public class TextClass
    {
        public Text speedText,bulletsText, magazineText, healthText, enemyHealthText, moneyText, dayText, workerText, nextDayText, gun1Text, gun2Text, gun3Text,enemyNameText,enemyInfoText, enemyInfoText1, enemyInfoText2, enemyInfoText3;

    }
    


    [System.Serializable]
    public class GameObjectClass
    {
        public GameObject canvas,upgradeMenu, nextLevelImage, impactEffect, impactEffect2, impactEffect3, gameOverScreen, nextDayButton, marketButton,newEnemyImage,enemyImage,arrowClone;

    }
    

    [System.Serializable]
    
    public class AudioSourceClass
    {
        public AudioSource audioSource, audioSource2, audioSource3;
       

    }



   void Awake()
    {
        if(deletesave)
        {
            PlayerPrefs.DeleteAll();
        }
       
        fireRate=  PlayerPrefs.GetFloat("fireRatePrefs", fireRate);
        armorPen = PlayerPrefs.GetFloat("armorPenPrefs", armorPen);
        Health = PlayerPrefs.GetFloat("healthLevelPrefs", Health);
        criticalChange = PlayerPrefs.GetInt("criticalChangePrefs", criticalChange);
        damage =PlayerPrefs.GetInt("damagePrefs", damage);
        tower =PlayerPrefs.GetInt("towerLevelPrefs", tower);
        day = PlayerPrefs.GetInt("dayPrefs", day);
        money = PlayerPrefs.GetInt("moneyPrefs", money);

        uprageMenu.intC.damageLevel= PlayerPrefs.GetInt("damageLevel", uprageMenu.intC.damageLevel);
        uprageMenu.intC.attackSpeedLevel = PlayerPrefs.GetInt("attackSpeedLevel", uprageMenu.intC.attackSpeedLevel);
        uprageMenu.intC.healthLevel = PlayerPrefs.GetInt("healthLevel", uprageMenu.intC.healthLevel);
        uprageMenu.intC.towerLevel = PlayerPrefs.GetInt("towerLevel", uprageMenu.intC.towerLevel);
        uprageMenu.intC.armorPenLevel = PlayerPrefs.GetInt("armorPenLevel", uprageMenu.intC.armorPenLevel);
        uprageMenu.intC.criticalChangeLevel = PlayerPrefs.GetInt("criticalChangeLevel", uprageMenu.intC.criticalChangeLevel);





        uprageMenu.intC.tower1DamageLevel = PlayerPrefs.GetInt("tower1DamageLevelPrefs");
        uprageMenu.intC.tower2DamageLevel = PlayerPrefs.GetInt("tower2DamageLevelPrefs", uprageMenu.intC.tower2DamageLevel);
        uprageMenu.intC.tower3DamageLevel = PlayerPrefs.GetInt("tower3DamageLevelPrefs", uprageMenu.intC.tower3DamageLevel);
        uprageMenu.intC.tower4DamageLevel = PlayerPrefs.GetInt("tower4DamageLevelPrefs", uprageMenu.intC.tower4DamageLevel);
        uprageMenu.intC.tower5DamageLevel = PlayerPrefs.GetInt("tower5DamageLevelPrefs", uprageMenu.intC.tower5DamageLevel);
        uprageMenu.intC.tower6DamageLevel = PlayerPrefs.GetInt("tower6DamageLevelPrefs", uprageMenu.intC.tower6DamageLevel);
      

        uprageMenu.intC.tower1attackSpeedLevel = PlayerPrefs.GetInt("tower1attackSpeedLevelPrefs", uprageMenu.intC.tower1attackSpeedLevel);
        uprageMenu.intC.tower2attackSpeedLevel = PlayerPrefs.GetInt("tower2attackSpeedLevelPrefs", uprageMenu.intC.tower2attackSpeedLevel);
        uprageMenu.intC.tower3attackSpeedLevel = PlayerPrefs.GetInt("tower3attackSpeedLevelPrefs", uprageMenu.intC.tower3attackSpeedLevel);
        uprageMenu.intC.tower4attackSpeedLevel = PlayerPrefs.GetInt("tower4attackSpeedLevelPrefs", uprageMenu.intC.tower4attackSpeedLevel);
        uprageMenu.intC.tower5attackSpeedLevel = PlayerPrefs.GetInt("tower5attackSpeedLevelPrefs", uprageMenu.intC.tower5attackSpeedLevel);
        uprageMenu.intC.tower6attackSpeedLevel = PlayerPrefs.GetInt("tower6attackSpeedLevelPrefs", uprageMenu.intC.tower6attackSpeedLevel);
      

        uprageMenu.tower1FireRate = PlayerPrefs.GetFloat("tower1FireRateLevelPrefs", uprageMenu.tower1FireRate);
        uprageMenu.tower2FireRate = PlayerPrefs.GetFloat("tower2FireRateLevelPrefs", uprageMenu.tower2FireRate);
        uprageMenu.tower3FireRate = PlayerPrefs.GetFloat("tower3FireRateLevelPrefs", uprageMenu.tower3FireRate);
        uprageMenu.tower4FireRate = PlayerPrefs.GetFloat("tower4FireRateLevelPrefs", uprageMenu.tower4FireRate);
        uprageMenu.tower5FireRate = PlayerPrefs.GetFloat("tower5FireRateLevelPrefs", uprageMenu.tower5FireRate);
        uprageMenu.tower6FireRate = PlayerPrefs.GetFloat("tower6FireRateLevelPrefs", uprageMenu.tower6FireRate);

        uprageMenu.intC.tower1ArmorPenLevel = PlayerPrefs.GetInt("tower1ArmorPenLevelPrefs", uprageMenu.intC.tower1ArmorPenLevel);
        uprageMenu.intC.tower2ArmorPenLevel = PlayerPrefs.GetInt("tower2ArmorPenLevelPrefs", uprageMenu.intC.tower2ArmorPenLevel);
        uprageMenu.intC.tower3ArmorPenLevel = PlayerPrefs.GetInt("tower3ArmorPenLevelPrefs", uprageMenu.intC.tower3ArmorPenLevel);
        uprageMenu.intC.tower4ArmorPenLevel = PlayerPrefs.GetInt("tower4ArmorPenLevelPrefs", uprageMenu.intC.tower4ArmorPenLevel);
        uprageMenu.intC.tower5ArmorPenLevel = PlayerPrefs.GetInt("tower5ArmorPenLevelPrefs", uprageMenu.intC.tower5ArmorPenLevel);
        uprageMenu.intC.tower6ArmorPenLevel = PlayerPrefs.GetInt("tower6ArmorPenLevelPrefs", uprageMenu.intC.tower6ArmorPenLevel);

        uprageMenu.intC.tower1CriticalChangeLevel=PlayerPrefs.GetInt("tower1CriticalChangeLevelPrefs", uprageMenu.intC.tower1CriticalChangeLevel);
        uprageMenu.intC.tower2CriticalChangeLevel = PlayerPrefs.GetInt("tower2CriticalChangeLevelPrefs", uprageMenu.intC.tower2CriticalChangeLevel);
        uprageMenu.intC.tower3CriticalChangeLevel = PlayerPrefs.GetInt("tower3CriticalChangeLevelPrefs", uprageMenu.intC.tower3CriticalChangeLevel);
        uprageMenu.intC.tower4CriticalChangeLevel = PlayerPrefs.GetInt("tower4CriticalChangeLevelPrefs", uprageMenu.intC.tower4CriticalChangeLevel);
        uprageMenu.intC.tower5CriticalChangeLevel = PlayerPrefs.GetInt("tower5CriticalChangeLevelPrefs", uprageMenu.intC.tower5CriticalChangeLevel);
        uprageMenu.intC.tower6CriticalChangeLevel = PlayerPrefs.GetInt("tower6CriticalChangeLevelPrefs", uprageMenu.intC.tower6CriticalChangeLevel);

       
        uprageMenu.fireArrowPurchased = PlayerPrefs.GetInt("poisonousArrowPurchased") !=0;
        uprageMenu.fireArrowPurchased = PlayerPrefs.GetInt("iceArrowPurchasedPrefs")  !=0;
        uprageMenu.fireArrowPurchased = PlayerPrefs.GetInt("fireArrowPurchasedPrefs") !=0;

       
    }


    void Start()
    {
       





        arrow2Control = true;
        arrow3Control = true;
        arrow4Control = true;

        //Market


        //  money = 500;
       
        isDied = false;
       

       
        nextDay = true;
        currentHealth = 100;
        Health = 100;
        menuOpen = false;
        
    }


    void Update()
    {

        if (speed == 1&&Time.timeScale!=0)
        {
           
            textC.speedText.text = "1X";
            Time.timeScale = 1;

        }
        else if (speed == 2 && Time.timeScale != 0)
        {
          
            textC.speedText.text = "2X";
            Time.timeScale = 2;
        }
        else if (speed == 3 && Time.timeScale != 0)
        {
           
            textC.speedText.text = "3X";
            Time.timeScale = 3;
        }



        textC.healthText.text = currentHealth.ToString();
        textC.enemyHealthText.text = currentEnemyCount.ToString("F0");
        healthImage.fillAmount = currentHealth / Health;
        enemyCountImage.fillAmount = currentEnemyCount / dailyEnemyCount;
        textC.moneyText.text = money.ToString();
        textC.nextDayText.text = "Day : " + day.ToString();
        textC.dayText.text = day.ToString();



       





        if (arrow2Buff&&arrow2Control)
        {
            arrow2Control = false;
            arrow3Control = true;
            arrow4Control = true;
           
            damage += 15;
           
            if (arrow3Buff)
            {
                slow = false;
            }
            if (arrow4Buff)
            {
                armorPen -= 10;
            }
            arrow3Buff = false;
            arrow4Buff = false;
        }
     
        if (arrow3Buff && arrow3Control)
        {
            arrow2Control = true;
            arrow3Control = false;
            arrow4Control = true;
            

            slow = true;
            if (arrow2Buff)
            {
               
                damage -= 15;
            }
            if (arrow4Buff)
            {
                armorPen -= 10;
            }
            arrow2Buff = false;
            arrow4Buff = false;
        }

       
        if (arrow4Buff && arrow4Control)
        {
            arrow2Control = true;
            arrow3Control = true;
            arrow4Control = false;

            armorPen += 10;
            
            if (arrow3Buff)
            {
                slow = false;
                
            }
            if (arrow2Buff)
            {
                damage -= 15;
            }
            arrow2Buff = false;
            arrow3Buff = false;
        }
       

       






        if (Input.GetKeyDown(KeyCode.Space))
        {
            money += 500;
        }


        for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] == null|| (enemies[i].GetComponent<enemyScrpit>().health<=0))
                {
                    enemies.RemoveAt(i);
                }

            }


            if (Input.GetMouseButton(0) && !menuOpen && !isDied)
            {
                if ((Time.realtimeSinceStartup) - lastFired > fireRate/speed)
                {

                    lastFired = (Time.realtimeSinceStartup);
                    
                gameObjectC.arrowClone = Instantiate(arrow, arrowPosition.transform.position, arrowPosition.transform.rotation);
                gameObjectC.arrowClone.GetComponent<ArrowScrpit>().damage =damage;
                gameObjectC.arrowClone.GetComponent<ArrowScrpit>().armorPen = armorPen;
                gameObjectC.arrowClone.GetComponent<ArrowScrpit>().criticalChange = criticalChange;
                gameObjectC.arrowClone.GetComponent<ArrowScrpit>().slow = slow;
                gameObjectC.arrowClone.GetComponent<
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    ArrowScrpit>().pos = Input.mousePosition;
                audioSourceC.audioSource.Play();
                    // anim.SetBool("isFire", false);

            }
            }


          
           

        if (currentHealth > Health) 
        {
            currentHealth = Health;
        }
     if (nextDay)
        {
            PlayerPrefs.SetFloat("fireRatePrefs", fireRate);
            PlayerPrefs.SetFloat("armorPenPrefs", armorPen);
            PlayerPrefs.SetFloat("healthLevelPrefs", Health);
            PlayerPrefs.SetInt("criticalChangePrefs", criticalChange);
            PlayerPrefs.SetInt("damagePrefs", damage);
            PlayerPrefs.SetInt("towerLevelPrefs", tower);
            PlayerPrefs.SetInt("dayPrefs", day);
            PlayerPrefs.SetInt("moneyPrefs", money);
            PlayerPrefs.SetInt("damageLevel", uprageMenu.intC.damageLevel);
            PlayerPrefs.SetInt("attackSpeedLevel", uprageMenu.intC.attackSpeedLevel);
            PlayerPrefs.SetInt("healthLevel", uprageMenu.intC.healthLevel);
            PlayerPrefs.SetInt("towerLevel", uprageMenu.intC.towerLevel);
            PlayerPrefs.SetInt("armorPenLevel", uprageMenu.intC.armorPenLevel);
            PlayerPrefs.SetInt("criticalChangeLevel", uprageMenu.intC.criticalChangeLevel);



            PlayerPrefs.SetInt("tower1DamageLevelPrefs", uprageMenu.intC.tower1DamageLevel);
            PlayerPrefs.SetInt("tower2DamageLevelPrefs", uprageMenu.intC.tower2DamageLevel);
            PlayerPrefs.SetInt("tower3DamageLevelPrefs", uprageMenu.intC.tower3DamageLevel);
            PlayerPrefs.SetInt("tower4DamageLevelPrefs", uprageMenu.intC.tower4DamageLevel);
            PlayerPrefs.SetInt("tower5DamageLevelPrefs", uprageMenu.intC.tower5DamageLevel);
            PlayerPrefs.SetInt("tower6DamageLevelPrefs", uprageMenu.intC.tower6DamageLevel);

            PlayerPrefs.SetInt("tower1attackSpeedLevelPrefs", uprageMenu.intC.tower1attackSpeedLevel);
            PlayerPrefs.SetInt("tower2attackSpeedLevelPrefs", uprageMenu.intC.tower2attackSpeedLevel);
            PlayerPrefs.SetInt("tower3attackSpeedLevelPrefs", uprageMenu.intC.tower3attackSpeedLevel);
            PlayerPrefs.SetInt("tower4attackSpeedLevelPrefs", uprageMenu.intC.tower4attackSpeedLevel);
            PlayerPrefs.SetInt("tower5attackSpeedLevelPrefs", uprageMenu.intC.tower5attackSpeedLevel);
            PlayerPrefs.SetInt("tower6attackSpeedLevelPrefs", uprageMenu.intC.tower6attackSpeedLevel);

            PlayerPrefs.SetFloat("tower1FireRateLevelPrefs", uprageMenu.tower1FireRate);
            PlayerPrefs.SetFloat("tower2FireRateLevelPrefs", uprageMenu.tower2FireRate);
            PlayerPrefs.SetFloat("tower3FireRateLevelPrefs", uprageMenu.tower3FireRate);
            PlayerPrefs.SetFloat("tower4FireRateLevelPrefs", uprageMenu.tower4FireRate);
            PlayerPrefs.SetFloat("tower5FireRateLevelPrefs", uprageMenu.tower5FireRate);
            PlayerPrefs.SetFloat("tower6FireRateLevelPrefs", uprageMenu.tower6FireRate);




            PlayerPrefs.SetInt("tower1ArmorPenLevelPrefs", uprageMenu.intC.tower1ArmorPenLevel);
            PlayerPrefs.SetInt("tower2ArmorPenLevelPrefs", uprageMenu.intC.tower2ArmorPenLevel);
            PlayerPrefs.SetInt("tower3ArmorPenLevelPrefs", uprageMenu.intC.tower3ArmorPenLevel);
            PlayerPrefs.SetInt("tower4ArmorPenLevelPrefs", uprageMenu.intC.tower4ArmorPenLevel);
            PlayerPrefs.SetInt("tower5ArmorPenLevelPrefs", uprageMenu.intC.tower5ArmorPenLevel);
            PlayerPrefs.SetInt("tower6ArmorPenLevelPrefs", uprageMenu.intC.tower6ArmorPenLevel);

            PlayerPrefs.SetInt("tower1CriticalChangeLevelPrefs", uprageMenu.intC.tower1CriticalChangeLevel);
            PlayerPrefs.SetInt("tower2CriticalChangeLevelPrefs", uprageMenu.intC.tower2CriticalChangeLevel);
            PlayerPrefs.SetInt("tower3CriticalChangeLevelPrefs", uprageMenu.intC.tower3CriticalChangeLevel);
            PlayerPrefs.SetInt("tower4CriticalChangeLevelPrefs", uprageMenu.intC.tower4CriticalChangeLevel);
            PlayerPrefs.SetInt("tower5CriticalChangeLevelPrefs", uprageMenu.intC.tower5CriticalChangeLevel);
            PlayerPrefs.SetInt("tower6CriticalChangeLevelPrefs", uprageMenu.intC.tower6CriticalChangeLevel);

            PlayerPrefs.SetInt("poisonousArrowPurchasedPrefs", (uprageMenu.poisonousArrowPurchased ? 1 : 0));
            PlayerPrefs.SetInt("iceArrowPurchasedPrefs", (uprageMenu.iceArrowPurchased ? 1 : 0));
            PlayerPrefs.SetInt("fireArrowPurchasedPrefs", (uprageMenu.fireArrowPurchased ? 1 : 0));
            // PlayerPrefs.SetInt("Name", (yourBool ? 1 : 0));
            //yourBool = (PlayerPrefs.GetInt("Name") != 0);

            isWaitinginMenu = true;
            Time.timeScale = 0;
            gameObjectC.nextDayButton.SetActive(true);
            for (int i = 0; i < enemies.Count; i++)
                {
                    Destroy(enemies[i].gameObject);
                }
            day++;
            gameObjectC.marketButton.SetActive(false);
            gameObjectC.upgradeMenu.gameObject.SetActive(false);
            menuOpen = false;
            OpenUpgradeMenu();
            currentHealth = Health;
            StartCoroutine(NextDayImageFalse(2.5f));
            nextDay = false;

           
        }

        if(currentHealth <= 0) 
        {
            isDied = true;
            Time.timeScale = 0;
         //   gameObjectC.canvas.SetActive(false);
            Debug.Log("deneme");
            gameObjectC.gameOverScreen.SetActive(true);
           
            
           
        }

    }


   

   

   
    
    
    IEnumerator Wait2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
       
        nextDay = true;
    }
    IEnumerator NextDayImageFalse(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        gameObjectC.nextLevelImage.SetActive(false);
        
    }
    


   

  
    public void OpenUpgradeMenu()
    {
        if(!menuOpen)
        {
            gameObjectC.upgradeMenu.gameObject.SetActive(true);
            gameObjectC.upgradeMenu.gameObject.transform.localScale = new Vector2(0.5f, 0.5f);
            menuOpen = true;
        }
        
       else if (menuOpen)
        {
            gameObjectC.upgradeMenu.gameObject.SetActive(false);
            menuOpen = false;
        }
        


    }

    
   
   
   
   
    public void NextDayButton()
    {
     
        Time.timeScale = speed;
        gameObjectC.nextLevelImage.SetActive(true);
        gameObjectC.marketButton.SetActive(true);
        OpenUpgradeMenu(); 
        gameObjectC.nextDayButton.SetActive(false);
        isWaitinginMenu = false;
       
           
    }
    public void ContinueGame() 
    {
       
        currentHealth = Health *(7.0F/10.0F);
        isDied = false;
        gameObjectC.gameOverScreen.SetActive(false);
        Time.timeScale = speed;
        gameObjectC.canvas.SetActive(true);

    }
  

    public void Money()
    {
        money += 5000;
    }
    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
    }
    public void SpeedButton()
    {
        if (speed == 1)
        {
            speed++;
            textC.speedText.text = "2X";
            
            
        }
       else if (speed == 2)
        {
            speed++;
            textC.speedText.text = "3X";
           
        }
       else if (speed == 3)
        {
            speed = 1;
            textC.speedText.text = "1X";
           
        }
    }
}
