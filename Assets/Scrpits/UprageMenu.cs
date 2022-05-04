using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UprageMenu : MonoBehaviour
{
    public TextClass textClass;
    public ImageClass imageClass;
    public GameObjectClass gameObjectC;
    public GameManagager gm;
    public intClass intC;
    public float tower1FireRate, tower2FireRate, tower3FireRate, tower4FireRate, tower5FireRate, tower6FireRate;
    public bool fireArrowPurchased, iceArrowPurchased, poisonousArrowPurchased, arrow2Buff, arrow3Buff, arrow4Buff, arrow2Buff2, arrow3Buff2, arrow4Buff2;
    public int selectedArrow;
    public AudioSource audioSource;

    [System.Serializable]
    public class GameObjectClass
    {
        public GameObject activeTab1, activeTab2, activeTab3, tower1, tower2, tower3, tower4, tower5, tower6;

    }
    [System.Serializable]
    public class intClass
    {
        public int selectedTower, damageCost, attackSpeedCost, healthCost, towerCost, armorPenCost, criticalChangeCost
            , damageLevel, attackSpeedLevel, healthLevel, towerLevel, armorPenLevel, criticalChangeLevel
            , tower1DamageLevel, tower1attackSpeedLevel, tower1ArmorPenLevel, tower1CriticalChangeLevel
            , tower2DamageLevel, tower2attackSpeedLevel, tower2ArmorPenLevel, tower2CriticalChangeLevel
            , tower3DamageLevel, tower3attackSpeedLevel, tower3ArmorPenLevel, tower3CriticalChangeLevel
            , tower4DamageLevel, tower4attackSpeedLevel, tower4ArmorPenLevel, tower4CriticalChangeLevel
            , tower5DamageLevel, tower5attackSpeedLevel, tower5ArmorPenLevel, tower5CriticalChangeLevel
            , tower6DamageLevel, tower6attackSpeedLevel, tower6ArmorPenLevel, tower6CriticalChangeLevel
            , fireArrow, iceArrow, posionArrow;



    }






    [System.Serializable]
    public class TextClass
    {
        public Text selectedTurretName, tabName, damageBackText, damageNextText, attackSpeedBackText, attackSpeedNextText,
            healthBackText, healthNextText, towerBackText, towerNextText, armorPenBackText,
            armorPenNextText, criticalChangeBackText, criticalChangeNextText, damageCostText,
            attackSpeedCostText, healthCostText, towerCostText, armorPenCostText, criticalChangeCostText, towerDamageBackText,
            towerDamageNextText, towerattackSpeedBackText, towerAttackSpeedNextText,
            towerArmorPenBackText, towerArmorPenNextText, towerCriticalChangeBackText,
            towerCriticalChangeNextText, towerDamageCostText,
            towerattackSpeedCostText, towerArmorPenCostText, towerCriticalChangeCostText, damageLevelText, attackSpeedLevelText, healthLevelText,
            towerLevelText, armorPenLevelText, criticalChangeLevelText,
            towerDamageLevelText, towerAttackSpeedLevelText, towerArmorPenLevelText, towerCriticalChangeLevelText
            , fireArrowCostText, iceArrowCostText, posionArrowCostText, woodenArrowCostText;
    }
    [System.Serializable]
    public class ImageClass
    {
        public Image damageCostBase, attackSpeedCostBase, healthCostBase, towerCostBase, armorPenCostBase,
            criticalChangeCostBase, fireArrowCostBase, iceArrowCostBase, posionArrowCostBase, towerDamageCostBase,
            towerattackSpeedCostBase, towerArmorPenCostBase, towerCriticalChangeCostBase, towerTab1, towerTab2, towerTab3,
            towerTab4, towerTab5, towerTab6, castleUpgradeButton, castleUpgradeButtonImage;

    }


    void Start()
    {
        arrow2Buff = true;
        arrow3Buff = true;
        arrow4Buff = true;



    }


    void Update()
    {



        gameObjectC.tower1.GetComponent<TurretScrpit>().damage = (intC.tower1DamageLevel + 1);
        gameObjectC.tower1.GetComponent<TurretScrpit>().fireRate = (tower1FireRate);
        gameObjectC.tower1.GetComponent<TurretScrpit>().damage = (intC.tower1DamageLevel + 1);
        gameObjectC.tower1.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower1ArmorPenLevel));
        gameObjectC.tower1.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower1CriticalChangeLevel);

        gameObjectC.tower2.GetComponent<TurretScrpit>().damage = (intC.tower2DamageLevel + 1);
        gameObjectC.tower2.GetComponent<TurretScrpit>().fireRate = (tower2FireRate);
        gameObjectC.tower2.GetComponent<TurretScrpit>().damage = (intC.tower2DamageLevel + 1);
        gameObjectC.tower2.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower2ArmorPenLevel));
        gameObjectC.tower2.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower2CriticalChangeLevel);

        gameObjectC.tower3.GetComponent<TurretScrpit>().damage = (intC.tower3DamageLevel + 1);
        gameObjectC.tower3.GetComponent<TurretScrpit>().fireRate = ((tower3FireRate));
        gameObjectC.tower3.GetComponent<TurretScrpit>().damage = (intC.tower3DamageLevel + 1);
        gameObjectC.tower3.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower3ArmorPenLevel));
        gameObjectC.tower3.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower3CriticalChangeLevel);

        gameObjectC.tower4.GetComponent<TurretScrpit>().damage = (intC.tower4DamageLevel + 1);
        gameObjectC.tower4.GetComponent<TurretScrpit>().fireRate = (tower4FireRate);
        gameObjectC.tower4.GetComponent<TurretScrpit>().damage = (intC.tower4DamageLevel + 1);
        gameObjectC.tower4.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower4ArmorPenLevel));
        gameObjectC.tower4.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower4CriticalChangeLevel);

        gameObjectC.tower5.GetComponent<TurretScrpit>().damage = (intC.tower5DamageLevel + 1);
        gameObjectC.tower5.GetComponent<TurretScrpit>().fireRate = (tower5FireRate);
        gameObjectC.tower5.GetComponent<TurretScrpit>().damage = (intC.tower5DamageLevel + 1);
        gameObjectC.tower5.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower5ArmorPenLevel));
        gameObjectC.tower5.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower5CriticalChangeLevel);

        gameObjectC.tower6.GetComponent<TurretScrpit>().damage = (intC.tower6DamageLevel + 1);
        gameObjectC.tower6.GetComponent<TurretScrpit>().fireRate = (tower6FireRate);
        gameObjectC.tower6.GetComponent<TurretScrpit>().damage = (intC.tower6DamageLevel + 1);
        gameObjectC.tower6.GetComponent<TurretScrpit>().armorPen = ((1.25f * intC.tower6ArmorPenLevel));
        gameObjectC.tower6.GetComponent<TurretScrpit>().criticalChange = 5 * (intC.tower6CriticalChangeLevel);


        // Arrow Tab
        if (gm.money < 2500 && !fireArrowPurchased)
        {
            textClass.fireArrowCostText.color = Color.red;
        }
        else
        {
            textClass.fireArrowCostText.color = Color.white;
        }
        if (gm.money < 2000 && !poisonousArrowPurchased)
        {
            textClass.posionArrowCostText.color = Color.red;
        }
        else
        {
            textClass.posionArrowCostText.color = Color.white;
        }
        if (gm.money < 1500 && !iceArrowPurchased)
        {
            textClass.iceArrowCostText.color = Color.red;
        }
        else
        {
            textClass.iceArrowCostText.color = Color.white;
        }


        // Tower Tab
        if (gm.tower >=1)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.castleUpgradeButton.gameObject.SetActive(true);
            imageClass.castleUpgradeButtonImage.gameObject.SetActive(true);
            gameObjectC.tower1.SetActive(true);



        }

        if (gm.tower >= 2)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.towerTab2.gameObject.SetActive(true);
            gameObjectC.tower2.SetActive(true);

        }

        if (gm.tower >= 3)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.towerTab2.gameObject.SetActive(true);
            imageClass.towerTab3.gameObject.SetActive(true);
            gameObjectC.tower3.SetActive(true);


        }
        if (gm.tower >= 4)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.towerTab2.gameObject.SetActive(true);
            imageClass.towerTab3.gameObject.SetActive(true);
            imageClass.towerTab4.gameObject.SetActive(true);
            gameObjectC.tower4.SetActive(true);

        }
         if (gm.tower >= 5)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.towerTab2.gameObject.SetActive(true);
            imageClass.towerTab3.gameObject.SetActive(true);
            imageClass.towerTab4.gameObject.SetActive(true);
            imageClass.towerTab5.gameObject.SetActive(true);
            gameObjectC.tower5.SetActive(true);

        }
         if (gm.tower == 6)
        {
            imageClass.towerTab1.gameObject.SetActive(true);
            imageClass.towerTab2.gameObject.SetActive(true);
            imageClass.towerTab3.gameObject.SetActive(true);
            imageClass.towerTab4.gameObject.SetActive(true);
            imageClass.towerTab5.gameObject.SetActive(true);
            imageClass.towerTab6.gameObject.SetActive(true);
            gameObjectC.tower6.SetActive(true);


        }
       




        textClass.selectedTurretName.text = ("Turret " + intC.selectedTower + " Upgrades").ToString();

        textClass.damageCostText.text = (intC.damageCost + (10 * intC.damageLevel)).ToString();
        textClass.damageBackText.text = gm.damage.ToString();
        textClass.damageNextText.text = (gm.damage + 1).ToString();
        textClass.damageLevelText.text = intC.damageLevel.ToString();
        if(gm.money < (intC.damageCost + (10 * intC.damageLevel))) 
        { 
            imageClass.damageCostBase.color = Color.gray;
            textClass.damageCostText.color = Color.red;


        }
        else
        {
            imageClass.damageCostBase.color = Color.white;
            textClass.damageCostText.color = Color.white;
        }

        textClass.attackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.attackSpeedLevel)).ToString();
        textClass.attackSpeedBackText.text = (1 / gm.fireRate).ToString("F2");
        textClass.attackSpeedNextText.text = (1 / (gm.fireRate - (5 * gm.fireRate / 100))).ToString("F2");
        textClass.attackSpeedLevelText.text = intC.attackSpeedLevel.ToString();
        if (gm.money < (intC.attackSpeedCost + (10 * intC.attackSpeedLevel)))
        {
            imageClass.attackSpeedCostBase.color = Color.gray;
            textClass.attackSpeedCostText.color = Color.red;


        }
        else
        {
            imageClass.attackSpeedCostBase.color = Color.white;
            textClass.attackSpeedCostText.color = Color.white;
        }


        textClass.healthCostText.text = (intC.healthCost + (50 * intC.healthLevel)).ToString();
        textClass.healthBackText.text = gm.Health.ToString();
        textClass.healthNextText.text = (gm.Health + 10).ToString();
        textClass.healthLevelText.text = intC.healthLevel.ToString();
        if (gm.money < (intC.healthCost + (50 * intC.healthLevel)))
        {
            imageClass.healthCostBase.color = Color.gray;
            textClass.healthCostText.color = Color.red;


        }
        else
        {
            imageClass.healthCostBase.color = Color.white;
            textClass.healthCostText.color = Color.white;
        }

        if (gm.tower == 6)
        {
            textClass.towerCostText.text = "Maximum Level";
        }

        else
        textClass.towerCostText.text = (intC.towerCost + (500 * gm.tower)).ToString();
        textClass.towerBackText.text = gm.tower.ToString();
        textClass.towerNextText.text = (gm.tower + 1).ToString();
        textClass.towerLevelText.text = gm.tower.ToString();


        if (gm.money < (intC.towerCost + (500 * gm.tower))&& gm.tower <= 5)
        {
            imageClass.towerCostBase.color = Color.gray;
            textClass.towerCostText.color = Color.red;


        }
        else
        {
            imageClass.towerCostBase.color = Color.white;
            textClass.towerCostText.color = Color.white;
        }
        if(gm.armorPen==100)
        {
            textClass.armorPenCostText.text = "Maximum Level";
            textClass.armorPenBackText.text = gm.armorPen.ToString();
            textClass.armorPenNextText.text = (gm.armorPen).ToString();
            textClass.armorPenLevelText.text = intC.armorPenLevel.ToString();
        }
        else
        {
            textClass.armorPenCostText.text = (intC.armorPenCost + (25 * intC.armorPenLevel)).ToString();
            textClass.armorPenBackText.text = gm.armorPen.ToString();
            textClass.armorPenNextText.text = (gm.armorPen + 1.25f).ToString();
            textClass.armorPenLevelText.text = intC.armorPenLevel.ToString();
        }


       
        if (gm.money < (intC.armorPenCost + (25 * intC.armorPenLevel))&&gm.armorPen<=100)
        {
            imageClass.armorPenCostBase.color = Color.gray;
            textClass.armorPenCostText.color = Color.red;


        }
        else
        {
            imageClass.armorPenCostBase.color = Color.white;
            textClass.armorPenCostText.color = Color.white;
        }

        if (gm.criticalChange == 100)
        {
            textClass.criticalChangeCostText.text = "Maximum Level";
            textClass.criticalChangeBackText.text = gm.criticalChange.ToString();
            textClass.criticalChangeNextText.text = (gm.criticalChange).ToString();
            textClass.criticalChangeLevelText.text = intC.criticalChangeLevel.ToString();
        }
        else
        {
            textClass.criticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.criticalChangeLevel)).ToString();
            textClass.criticalChangeBackText.text = gm.criticalChange.ToString();
            textClass.criticalChangeNextText.text = (gm.criticalChange + 5).ToString();
            textClass.criticalChangeLevelText.text = intC.criticalChangeLevel.ToString();
        }
        
        if (gm.money < (intC.criticalChangeCost + (400 * intC.criticalChangeLevel))&&gm.criticalChange<100)
        {
            imageClass.criticalChangeCostBase.color = Color.gray;
            textClass.criticalChangeCostText.color = Color.red;


        }
        else
        {
            imageClass.criticalChangeCostBase.color = Color.white;
            textClass.criticalChangeCostText.color = Color.white;
        }




        if (intC.selectedTower == 1)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower1DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower1DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower1DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower1DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower1DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }



            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower1attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower1FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower1FireRate - (5*tower1FireRate/100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower1attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower1attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }

            if((1.25f * intC.tower1ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower1ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower1ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower1ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower1ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower1ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower1ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower1ArmorPenLevel.ToString();
            }
           
            if (gm.money < (intC.armorPenCost + (25 * intC.tower1ArmorPenLevel)) && (1.25f * intC.tower1ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }

            if(intC.tower1CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower1CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 *intC.tower1CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower1CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower1CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower1CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower1CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower1CriticalChangeLevel.ToString();
            }
           
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower1CriticalChangeLevel)) && intC.tower1CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }



        }
        else if (intC.selectedTower == 2)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower2DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower2DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower2DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower2DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower2DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }


            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower2attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower2FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower2FireRate - (5 * tower2FireRate / 100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower2attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower2attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }




            if ((1.25f * intC.tower2ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower2ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower2ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower2ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower2ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower2ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower2ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower2ArmorPenLevel.ToString();
            }
            if (gm.money < (intC.armorPenCost + (25 * intC.tower2ArmorPenLevel)) && (1.25f * intC.tower2ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }


            if (intC.tower2CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower2CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower2CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower2CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower2CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower2CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower2CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower2CriticalChangeLevel.ToString();
            }
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower2CriticalChangeLevel)) && intC.tower2CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }

        }
        else if (intC.selectedTower == 3)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower3DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower3DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower3DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower3DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower3DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }


            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower3attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower3FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower3FireRate - (5 * tower3FireRate / 100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower3attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower3attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }


            if ((1.25f * intC.tower3ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower3ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower3ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower3ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower3ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower3ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower3ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower3ArmorPenLevel.ToString();
            }
            if (gm.money < (intC.armorPenCost + (25 * intC.tower3ArmorPenLevel)) && (1.25f * intC.tower3ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }


            if (intC.tower3CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower3CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower3CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower3CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower3CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower3CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower3CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower3CriticalChangeLevel.ToString();
            }
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower3CriticalChangeLevel)) && intC.tower3CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }

        }
        else if (intC.selectedTower == 4)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower4DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower4DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower4DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower4DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower4DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }


            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower4attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower4FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower4FireRate - (5 * tower4FireRate / 100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower4attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower4attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }


            if ((1.25f * intC.tower4ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower4ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower4ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower4ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower4ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower4ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower4ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower4ArmorPenLevel.ToString();
            }
            if (gm.money < (intC.armorPenCost + (25 * intC.tower4ArmorPenLevel)) && (1.25f * intC.tower4ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }


            if (intC.tower4CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower4CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower4CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower4CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower4CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower4CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower4CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower4CriticalChangeLevel.ToString();
            }
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower4CriticalChangeLevel)) && intC.tower4CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }

        }
        else if (intC.selectedTower == 5)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower5DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower5DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower5DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower5DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower5DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }


            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower5attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower5FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower5FireRate - (5 * tower5FireRate / 100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower5attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower5attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }


            if ((1.25f * intC.tower5ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower5ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower5ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower5ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower5ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower5ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower5ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower5ArmorPenLevel.ToString();
            }
            if (gm.money < (intC.armorPenCost + (25 * intC.tower5ArmorPenLevel)) && (1.25f * intC.tower5ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }


            if (intC.tower5CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower5CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower5CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower5CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower5CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower5CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower5CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower5CriticalChangeLevel.ToString();
            }
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower5CriticalChangeLevel)) && intC.tower5CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }

        }
        else if (intC.selectedTower == 6)
        {

            textClass.towerDamageCostText.text = (intC.damageCost + (10 * intC.tower6DamageLevel)).ToString();
            textClass.towerDamageBackText.text = (intC.tower6DamageLevel + 1).ToString();
            textClass.towerDamageNextText.text = (intC.tower6DamageLevel + 2).ToString();
            textClass.towerDamageLevelText.text = intC.tower6DamageLevel.ToString();
            if (gm.money < (intC.damageCost + (10 * intC.tower6DamageLevel)))
            {
                imageClass.towerDamageCostBase.color = Color.gray;
                textClass.towerDamageCostText.color = Color.red;


            }
            else
            {
                imageClass.towerDamageCostBase.color = Color.white;
                textClass.towerDamageCostText.color = Color.white;
            }


            textClass.towerattackSpeedCostText.text = (intC.attackSpeedCost + (10 * intC.tower6attackSpeedLevel)).ToString();
            textClass.towerattackSpeedBackText.text = (1 / (tower6FireRate)).ToString("F2");
            textClass.towerAttackSpeedNextText.text = (1 / (tower6FireRate - (5 * tower6FireRate / 100))).ToString("F2");
            textClass.towerAttackSpeedLevelText.text = intC.tower6attackSpeedLevel.ToString();
            if (gm.money < (intC.attackSpeedCost + (10 * intC.tower6attackSpeedLevel)))
            {
                imageClass.towerattackSpeedCostBase.color = Color.gray;
                textClass.towerattackSpeedCostText.color = Color.red;


            }
            else
            {
                imageClass.towerattackSpeedCostBase.color = Color.white;
                textClass.towerattackSpeedCostText.color = Color.white;
            }


            if ((1.25f * intC.tower6ArmorPenLevel) == 100)
            {
                textClass.towerArmorPenCostText.text = "Maximum Level";
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower6ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = ((1.25f * intC.tower6ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower6ArmorPenLevel.ToString();
            }
            else
            {
                textClass.towerArmorPenCostText.text = (intC.armorPenCost + (25 * intC.tower6ArmorPenLevel)).ToString();
                textClass.towerArmorPenBackText.text = (0 + (1.25f * intC.tower6ArmorPenLevel)).ToString();
                textClass.towerArmorPenNextText.text = (1.25 + (1.25f * intC.tower6ArmorPenLevel)).ToString();
                textClass.towerArmorPenLevelText.text = intC.tower6ArmorPenLevel.ToString();
            }
            if (gm.money < (intC.armorPenCost + (25 * intC.tower6ArmorPenLevel)) && (1.25f * intC.tower6ArmorPenLevel) < 100)
            {
                imageClass.towerArmorPenCostBase.color = Color.gray;
                textClass.towerArmorPenCostText.color = Color.red;


            }
            else
            {
                imageClass.towerArmorPenCostBase.color = Color.white;
                textClass.towerArmorPenCostText.color = Color.white;
            }


            if (intC.tower6CriticalChangeLevel == 20)
            {
                textClass.towerCriticalChangeCostText.text = "Maximum Level";
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower6CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower6CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower6CriticalChangeLevel.ToString();
            }
            else
            {
                textClass.towerCriticalChangeCostText.text = (intC.criticalChangeCost + (400 * intC.tower6CriticalChangeLevel)).ToString();
                textClass.towerCriticalChangeBackText.text = (5 * intC.tower6CriticalChangeLevel).ToString();
                textClass.towerCriticalChangeNextText.text = ((5 * intC.tower6CriticalChangeLevel) + 5).ToString();
                textClass.towerCriticalChangeLevelText.text = intC.tower6CriticalChangeLevel.ToString();
            }
            if (gm.money < (intC.criticalChangeCost + (400 * intC.tower6CriticalChangeLevel))&& intC.tower6CriticalChangeLevel < 20)
            {
                imageClass.towerCriticalChangeCostBase.color = Color.gray;
                textClass.towerCriticalChangeCostText.color = Color.red;


            }
            else
            {
                imageClass.towerCriticalChangeCostBase.color = Color.white;
                textClass.towerCriticalChangeCostText.color = Color.white;
            }

        }

        if (selectedArrow != 1)
        {
            textClass.woodenArrowCostText.text = "Equip";
        }

        if (selectedArrow != 2  && fireArrowPurchased)
        {
            textClass.fireArrowCostText.text = "Equip";
        }
        if (selectedArrow != 3 && iceArrowPurchased)
        {
            textClass.iceArrowCostText.text = "Equip";
        }

        if (selectedArrow != 4 && poisonousArrowPurchased)
        {
            textClass.posionArrowCostText.text = "Equip";
        }

        if (selectedArrow == 1)
        {
            textClass.woodenArrowCostText.text = "Equipped";
        }
        if (selectedArrow == 2)
        {
            textClass.fireArrowCostText.text = "Equipped";
          
          
        }
        if (selectedArrow == 3)
        {
            textClass.iceArrowCostText.text = "Equipped";
        }
        if (selectedArrow == 4)
        {
            textClass.posionArrowCostText.text = "Equipped";
        }


    }
    public void SelectTower(int number)
    {
        audioSource.Play();
        intC.selectedTower = number;
        if (intC.selectedTower == 1)
        {
            imageClass.towerTab1.color = Color.red;
            imageClass.towerTab2.color = Color.white;
            imageClass.towerTab3.color = Color.white;
            imageClass.towerTab4.color = Color.white;
            imageClass.towerTab5.color = Color.white;
            imageClass.towerTab6.color = Color.white;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.75f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (intC.selectedTower == 2)
        {
            imageClass.towerTab1.color = Color.white;
            imageClass.towerTab2.color = Color.red;
            imageClass.towerTab3.color = Color.white;
            imageClass.towerTab4.color = Color.white;
            imageClass.towerTab5.color = Color.white;
            imageClass.towerTab6.color = Color.white;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.75f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (intC.selectedTower == 3)
        {
            imageClass.towerTab1.color = Color.white;
            imageClass.towerTab2.color = Color.white;
            imageClass.towerTab3.color = Color.red;
            imageClass.towerTab4.color = Color.white;
            imageClass.towerTab5.color = Color.white;
            imageClass.towerTab6.color = Color.white;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.75f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (intC.selectedTower == 4)
        {
            imageClass.towerTab1.color = Color.white;
            imageClass.towerTab2.color = Color.white;
            imageClass.towerTab3.color = Color.white;
            imageClass.towerTab4.color = Color.red;
            imageClass.towerTab5.color = Color.white;
            imageClass.towerTab6.color = Color.white;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.75f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (intC.selectedTower == 5)
        {
            imageClass.towerTab1.color = Color.white;
            imageClass.towerTab2.color = Color.white;
            imageClass.towerTab3.color = Color.white;
            imageClass.towerTab4.color = Color.white;
            imageClass.towerTab5.color = Color.red;
            imageClass.towerTab6.color = Color.white;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.75f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
        if (intC.selectedTower == 6)
        {
            imageClass.towerTab1.color = Color.white;
            imageClass.towerTab2.color = Color.white;
            imageClass.towerTab3.color = Color.white;
            imageClass.towerTab4.color = Color.white;
            imageClass.towerTab5.color = Color.white;
            imageClass.towerTab6.color = Color.red;

            imageClass.towerTab1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab5.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            imageClass.towerTab6.transform.localScale = new Vector3(0.5f, 0.75f, 1);
        }
    }

    public void BuyUpgrade(string updatename)
    {

        audioSource.Play();


        if (updatename.Equals("damage") && gm.money >= (intC.damageCost + (10 * intC.damageLevel)))
        {
            gm.damage++;
            gm.money -= intC.damageCost + (10 * intC.damageLevel);
            intC.damageLevel++;

        }
        if (updatename.Equals("attackspeed") && gm.money >= (intC.attackSpeedCost + (10 * intC.attackSpeedLevel)))
        {
            gm.fireRate -= (5 * gm.fireRate / 100);
            gm.money -= intC.attackSpeedCost + (10 * intC.attackSpeedLevel);
            intC.attackSpeedLevel++;


        }
        if (updatename.Equals("health") && gm.money >= (intC.healthCost + (50 * intC.healthLevel)))
        {
            gm.Health += 10;
            gm.money -= intC.healthCost + (50 * intC.healthLevel);
            intC.healthLevel++;


        }
        if (updatename.Equals("tower") && gm.money >= (intC.towerCost + (500 * gm.tower))&& gm.tower <= 5)
        {
          
            gm.money -= intC.towerCost + (500 * gm.tower);
            gm.tower += 1;


        }
        if (updatename.Equals("armorpen") && gm.money >= (intC.armorPenCost + (25 * intC.armorPenLevel)) && gm.armorPen < 100)
        {
            gm.armorPen += 1.25f;

            gm.money -= intC.armorPenCost + (25 * intC.armorPenLevel);
            intC.armorPenLevel++;


        }
        if (updatename.Equals("criticalchange") && gm.money >= (intC.criticalChangeCost + (400 * intC.criticalChangeLevel)) && gm.criticalChange <= 100)
        {
            gm.criticalChange += 5;

            gm.money -= intC.criticalChangeCost + (400 * intC.criticalChangeLevel);
            intC.criticalChangeLevel++;
        }
        // Tower 1
        if (updatename.Equals("towerdamage") && intC.selectedTower == 1 && gm.money >= (intC.damageCost + (10 * intC.tower1DamageLevel)))
        {
            gm.money -= intC.damageCost + (10 * intC.tower1DamageLevel);
            intC.tower1DamageLevel++;


        }
        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 1 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower1attackSpeedLevel)))
        {

            gm.money -= intC.attackSpeedCost + (10 * intC.tower1attackSpeedLevel);
            intC.tower1attackSpeedLevel++;
            tower1FireRate -= (5 * tower1FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 1 && gm.money >= (intC.armorPenCost + (25 * intC.tower1ArmorPenLevel))&& (1.25f * intC.tower1ArmorPenLevel)<100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower1ArmorPenLevel);
            intC.tower1ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 1 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower1CriticalChangeLevel))&& intC.tower1CriticalChangeLevel<20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower1CriticalChangeLevel);
            intC.tower1CriticalChangeLevel++;
        }

        // Tower 2
        if (updatename.Equals("towerdamage") && intC.selectedTower == 2 && gm.money >= (intC.damageCost + (10 * intC.tower2DamageLevel)))
        {

            gm.money -= intC.damageCost + (10 * intC.tower2DamageLevel);
            intC.tower2DamageLevel++;
        }
        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 2 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower2attackSpeedLevel)))
        {

            gm.money -= intC.attackSpeedCost + (10 * intC.tower2attackSpeedLevel);
            intC.tower2attackSpeedLevel++;
            tower2FireRate -= (5 * tower2FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 2 && gm.money >= (intC.armorPenCost + (25 * intC.tower2ArmorPenLevel)) && (1.25f * intC.tower2ArmorPenLevel) < 100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower2ArmorPenLevel);
            intC.tower2ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 2 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower2CriticalChangeLevel))&&intC.tower2CriticalChangeLevel < 20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower2CriticalChangeLevel);
            intC.tower2CriticalChangeLevel++;
        }
        // Tower 3
        if (updatename.Equals("towerdamage") && intC.selectedTower == 3 && gm.money >= (intC.damageCost + (10 * intC.tower3DamageLevel)))
        {

            gm.money -= intC.damageCost + (10 * intC.tower3DamageLevel);
            intC.tower3DamageLevel++;
        }

        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 3 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower3attackSpeedLevel)))
        {
            intC.tower3attackSpeedLevel++;
            gm.money -= intC.attackSpeedCost + (10 * intC.tower3attackSpeedLevel);
            tower3FireRate -= (5 * tower3FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 3 && gm.money >= (intC.armorPenCost + (25 * intC.tower3ArmorPenLevel)) && (1.25f * intC.tower3ArmorPenLevel) < 100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower3ArmorPenLevel);
            intC.tower3ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 3 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower3CriticalChangeLevel)) && intC.tower3CriticalChangeLevel < 20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower3CriticalChangeLevel);
            intC.tower3CriticalChangeLevel++;
        }
        // Tower 4
        if (updatename.Equals("towerdamage") && intC.selectedTower == 4 && gm.money >= (intC.damageCost + (10 * intC.tower4DamageLevel)))
        {

            gm.money -= intC.damageCost + (10 * intC.tower4DamageLevel);
            intC.tower4DamageLevel++;
        }
        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 4 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower4attackSpeedLevel)))
        {

            gm.money -= intC.attackSpeedCost + (10 * intC.tower4attackSpeedLevel);
            intC.tower4attackSpeedLevel++;
            tower4FireRate -= (5 * tower4FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 4 && gm.money >= (intC.armorPenCost + (25 * intC.tower4ArmorPenLevel)) && (1.25f * intC.tower4ArmorPenLevel) < 100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower4ArmorPenLevel);
            intC.tower4ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 4 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower4CriticalChangeLevel)) && intC.tower4CriticalChangeLevel < 20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower4CriticalChangeLevel);
            intC.tower4CriticalChangeLevel++;
        }
        // Tower 5
        if (updatename.Equals("towerdamage") && intC.selectedTower == 5 && gm.money >= (intC.damageCost + (10 * intC.tower5DamageLevel)))
        {

            gm.money -= intC.damageCost + (10 * intC.tower5DamageLevel);
            intC.tower5DamageLevel++;
        }
        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 5 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower5attackSpeedLevel)))
        {

            gm.money -= intC.attackSpeedCost + (10 * intC.tower5attackSpeedLevel);
            intC.tower5attackSpeedLevel++;
            tower5FireRate -= (5 * tower5FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 5 && gm.money >= (intC.armorPenCost + (25 * intC.tower5ArmorPenLevel)) && (1.25f * intC.tower5ArmorPenLevel) < 100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower5ArmorPenLevel);
            intC.tower5ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 5 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower5CriticalChangeLevel)) && intC.tower5CriticalChangeLevel < 20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower5CriticalChangeLevel);
            intC.tower5CriticalChangeLevel++;
        }
        // Tower 6
        if (updatename.Equals("towerdamage") && intC.selectedTower == 6 && gm.money >= (intC.damageCost + (10 * intC.tower6DamageLevel)))
        {

            gm.money -= intC.damageCost + (10 * intC.tower6DamageLevel);
            intC.tower6DamageLevel++;
        }
        if (updatename.Equals("towerattackspeed") && intC.selectedTower == 6 && gm.money >= (intC.attackSpeedCost + (10 * intC.tower6attackSpeedLevel)))
        {

            gm.money -= intC.attackSpeedCost + (10 * intC.tower6attackSpeedLevel);
            intC.tower6attackSpeedLevel++;
           tower6FireRate -= (5 * tower6FireRate / 100);
        }
        if (updatename.Equals("towerarmorpen") && intC.selectedTower == 6 && gm.money >= (intC.armorPenCost + (25 * intC.tower6ArmorPenLevel)) && (1.25f * intC.tower6ArmorPenLevel) < 100)
        {

            gm.money -= intC.armorPenCost + (25 * intC.tower6ArmorPenLevel);
            intC.tower6ArmorPenLevel++;
        }
        if (updatename.Equals("towercriticalchange") && intC.selectedTower == 6 && gm.money >= (intC.criticalChangeCost + (400 * intC.tower6CriticalChangeLevel)) && intC.tower6CriticalChangeLevel < 20)
        {

            gm.money -= intC.criticalChangeCost + (400 * intC.tower6CriticalChangeLevel);
            intC.tower6CriticalChangeLevel++;
        }

    }

    public void BuyArrow(int number)
    {
        audioSource.Play();

        if (number==1)
        {
            selectedArrow = 1;
            gm.arrow2Buff = false;
            gm.arrow3Buff = false;
            gm.arrow4Buff = false;


        }

        if (number == 2 && (gm.money>= 2500 || fireArrowPurchased))
        {
          
            if(!fireArrowPurchased)
            {
                gm.money -= 2500;
            }

            fireArrowPurchased = true;
            selectedArrow = 2;
            gm.arrow2Buff = true;
          


        }

        if (number == 3 && (gm.money >= 1500 || iceArrowPurchased))
        {

            if (!iceArrowPurchased)
            {
                gm.money -= 1500;
            }
            iceArrowPurchased = true;
            selectedArrow = 3;
            gm.arrow3Buff = true;
          

        }
        if (number == 4 && (gm.money >= 2000 || poisonousArrowPurchased))
        {

            if (!poisonousArrowPurchased)
            {
                gm.money -= 2000;
            }
            poisonousArrowPurchased = true;
            selectedArrow = 4;
            gm.arrow4Buff = true;
         
          

        }

    }





    public void ActiveTab(int number)
    {
        audioSource.Play();

        if (number == 1)
        {
            gameObjectC.activeTab1.SetActive(true);
            gameObjectC.activeTab2.SetActive(false);
            gameObjectC.activeTab3.SetActive(false);
            textClass.tabName.text = "STATS";
        }

        if (number == 2)
        {
            gameObjectC.activeTab2.SetActive(true);
            gameObjectC.activeTab3.SetActive(false);
            gameObjectC.activeTab1.SetActive(false);
            textClass.tabName.text = "Arrow Upgrades";
        }

        if (number == 3)
        {
            gameObjectC.activeTab3.SetActive(true);
            gameObjectC.activeTab2.SetActive(false);
            gameObjectC.activeTab1.SetActive(false);
            textClass.tabName.text = "Tower Upgrades";
        }
    }
}
