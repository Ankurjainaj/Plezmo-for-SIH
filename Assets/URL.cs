using System.Collections;
using UnityEngine;

public class URL : MonoBehaviour
{

    public void connect(string url)
    {
        Application.OpenURL(url);
    }
}