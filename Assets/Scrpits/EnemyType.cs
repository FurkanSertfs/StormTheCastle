using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class EnemyType : ScriptableObject
{
    public GameObject enemy;
    public string enemyName,enemyInfo,enemyInfo1, enemyInfo2, enemyInfo3;
    public float health, armor, helmetarmor, damage,fireRate,speed,weight,rate;
    public int award,waveStart,dailyCount,type;
    public bool range;
    public Sprite enemyImage;
    

}
