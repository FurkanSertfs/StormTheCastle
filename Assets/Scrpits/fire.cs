using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject arrow,carrow;
    public Transform arrowTransform,enemy;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void Fire()
    {
        Instantiate(arrow, arrowTransform.transform.position, arrowTransform.transform.rotation);
    }
    void FireOff()
    {
        anim.SetBool("isFire", false);
    }

}
