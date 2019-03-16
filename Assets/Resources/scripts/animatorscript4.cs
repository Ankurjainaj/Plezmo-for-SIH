using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorscript4 : MonoBehaviour
{
    public int yes;
    public AudioSource asource;
    public AudioClip a1, a2, a3, a4;
    public void ones()
    {
        asource.PlayOneShot(a1);
    }
    public void twos()
    {
        asource.PlayOneShot(a2);
    }
    public void threes()
    {
        asource.PlayOneShot(a3);
    }
    public void fourss()
    {
        asource.PlayOneShot(a4);
    }

    void Start()
    {
       
    }

}