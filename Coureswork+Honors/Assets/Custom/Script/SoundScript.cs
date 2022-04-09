using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    void OnTriggerEnter(Collider ent) 
    {
        this.GetComponent<AudioSource>().Play();

    }
    void OnTriggerExit(Collider ext) 
    {
        this.GetComponent<AudioSource>().Stop();
    }
}
