using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessage : MonoBehaviour
{

    public string message;
    public TextController controller;
    public bool repeat;
    private bool hasPlayed;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        hasPlayed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider trigger)
    {
        if (repeat || !hasPlayed){
            controller.PlayMessage(message);
        }
        hasPlayed = true;
    }

}
