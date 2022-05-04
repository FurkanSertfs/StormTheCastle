using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScrpit : MonoBehaviour
{
    public float x, y, z;
    void Start()
    {
        transform.rotation = Quaternion.Euler(x, y, z);
    }

    
  
}
