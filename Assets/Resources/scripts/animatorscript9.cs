﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript9 : MonoBehaviour
{
    public void Changein()
    {
        anim.SetBool("boxopen1", true);
        anim.SetBool("indexout", false);

    }
    public void Changeout()
    {
        anim.SetBool("indexout", true);
        anim.SetBool("indexin", false);

    }
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   

}
   
