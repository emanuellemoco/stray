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


    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
        
    }

    // Update is called once per frame
    void Update()
    {
            if (trigger){
                t += Time.deltaTime/time;
                transform.position = Vector3.Lerp(start.position, end.position, t);
            }
    }
}
