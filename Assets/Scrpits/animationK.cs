using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationK : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        
        if (transform.localScale.x < 1)
        {
            transform.localScale = new Vector2(transform.localScale.x + 2*Time.fixedDeltaTime, transform.localScale.y + 2 * Time.fixedDeltaTime);
            
        }
        
    }
}
