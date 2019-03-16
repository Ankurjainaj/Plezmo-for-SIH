using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript2 : MonoBehaviour
{
    public int yes;
    public void Changein()
    {
        yes = anim.GetInteger("play");
        anim.SetBool("windowempty", true);
        anim.SetInteger("play", yes + 1);

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
   
