using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorrorSound : MonoBehaviour
{
    [SerializeField]
    private AudioClip[]  clips = new AudioClip[7] ;

    [SerializeField]
    private AudioSource audio;

    private float timer;
    private int timeWait;
    private int soundIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        timeWait = Random.Range(60, 110);

        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeWait){
            PickAndPlay();
        }
        
    }

    void PickAndPlay()
    {
        soundIndex = Random.Range(0,9);
        audio.clip = clips[soundIndex];
        audio.Play();

        timer = 0f;
        timeWait = Random.Range(60, 110);


    }




}
