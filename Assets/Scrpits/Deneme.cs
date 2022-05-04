using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deneme : MonoBehaviour
{
    public Guns gun;
    void Start()
    {
        gun = Instantiate<Guns>(gun);
    }

    void Update()
    {
        
    }
}
