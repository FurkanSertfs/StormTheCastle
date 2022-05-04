using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public float volume;
    
    void Start()
    {
        
    }

    void Update()
    {
        GetComponent<AudioSource>().volume = volume;
    }
    public void NoSound()
    {
        
        if (volume == 0)
            volume = 0.041f;
        volume = 0;

    }
    public void LowSound()
    {

        if (volume == 0.011f)
            volume = 0.041f;
        volume = 0.011f;

    }

}
