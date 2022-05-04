using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour
{
    public GameObject effect,effectClone;
    public Transform firepos;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
   public void fire()
    {

        effectClone = Instantiate(effect, firepos.transform.position, firepos.transform.rotation);
        effectClone.GetComponent<SkillScrpit>().enemyScrpit = GetComponentInParent<enemyScrpit>();
    }






}
