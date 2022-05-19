using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 
public class GateLogic : MonoBehaviour
{
    private bool isOpen;
    int degrees = 90;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }
     void Update(){
         if (isOpen){
                transform.Rotate(Vector3.up* Time.deltaTime);
         }
    }
    public void openDoor(){
        isOpen = true;
        transform.Rotate(0, 90, 0);

    }
}
