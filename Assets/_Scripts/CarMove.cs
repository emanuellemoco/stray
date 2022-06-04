using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public bool trigger = false;
    public Transform start;

    public Transform end;

    public float time;
    float t = 0;

    public AudioSource sound;

    public GameObject light;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
        
    }

    // Update is called once per frame
    void Update()
    {
            if (trigger){
                t += Time.deltaTime/time * 2;
                transform.position = Vector3.Lerp(start.position, end.position, t);
            }
    }

    public void Move(){
        trigger = true;
        StartCoroutine("BlinkLight");
        sound.Play();
    }


    IEnumerator BlinkLight()
    {

        while (true){
        //Print the time of when the function is first called.
        light.SetActive(true);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(.5f);

        //After we have waited 5 seconds print the time again.
        light.SetActive(false);
        yield return new WaitForSeconds(.2f);
        }
        
    }

}
