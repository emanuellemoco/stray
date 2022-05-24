using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class PlaySound : MonoBehaviour
{

    AudioSource audioSource; 
    public void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayS()
    {
        print("soundplay");
        audioSource.Play();
    }
   
}
 
