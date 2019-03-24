using UnityEngine.Audio;
using UnityEngine;
using System;

public class audioManager : MonoBehaviour
{

    public AudioSource source;
    public AudioClip hover;
    public AudioClip click;


    public void onHover()
    {
        source.PlayOneShot(hover);
    }

    public void onClick()
    {
        source.PlayOneShot(click);
    }

}

