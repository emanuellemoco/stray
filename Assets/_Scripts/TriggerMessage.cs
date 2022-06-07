using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessage : MonoBehaviour
{

    public string message;
    public TextController controller;
    int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider trigger)
    {
        Debug.Log("Enter trigger");
        //int.TryParse(trigger.tag, out index);

        controller.PlayMessage(message);
    }

}
