using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Turrets : ScriptableObject
{

  
    public int damage, armorPen;
    public float fireRate;
    public int level, cost;
    public GameObject arrow;
    public AudioClip sound;
    public Sprite Sprite;
    
}

