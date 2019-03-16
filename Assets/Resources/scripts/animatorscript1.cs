using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript1 : MonoBehaviour
{
    public int yes;
    public AudioSource asource;
    public AudioClip a1, a2, a3, a4, a5, a6, a7;
    public void Changein()
    {
        yes = anim.GetInteger("play");
        anim.SetBool("plateout", true);
        anim.SetBool("indexout", false);
        anim.SetInteger("play",yes+1);
    }
    public void Changeout()
    {
        yes = anim.GetInteger("play");
       
        anim.SetInteger("play", yes - 1);
    }
    public void playinga()
    {
        yes = anim.GetInteger("play");
        if (yes == 1)
        {
            asource.Stop();
            asource.PlayOneShot(a1);
        }
        if (yes == 2)
        {
            asource.Stop();
            asource.PlayOneShot(a2);
        }
        if (yes == 3)
        {
            asource.Stop();
            asource.PlayOneShot(a3);
        }
        if (yes == 4)
        {
            asource.Stop();
            asource.PlayOneShot(a4);
        }
        if (yes == 5)
        {
            asource.Stop();
            asource.PlayOneShot(a5);
        }
        if (yes == 6)
        {
            asource.Stop();
            asource.PlayOneShot(a6);
        }
        if (yes == 7)
        {
            asource.Stop();
            asource.PlayOneShot(a7);
        }

    }
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        yes = anim.GetInteger("play");
    }
    void Update()
    {
       
    }
    // Update is called once per frame


}
   
