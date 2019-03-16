using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript3 : MonoBehaviour
{
    public int yes;
   
    public void repeat()
    {
        yes = anim.GetInteger("play");
        anim.SetInteger("play", yes + 1);
    
     
    }

    private void WaitForSecondsRealtime(int v)
    {
        throw new NotImplementedException();
    }

    public void repeat2()
    {
        yes = anim.GetInteger("play");
        anim.SetInteger("play", yes - 1);
    }
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   

}
   
