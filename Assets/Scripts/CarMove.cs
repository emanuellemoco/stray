using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{

    public Transform start;

    public Transform end;

    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position = Vector3.Lerp(start.position, end.position, vel * Time.deltaTime);
    }
}
