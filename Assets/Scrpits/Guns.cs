using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Guns : ScriptableObject
{

    
    public int damage,armorPen, cost;
    public bool automatic;
    public float fireRate,reloadtime;
}
