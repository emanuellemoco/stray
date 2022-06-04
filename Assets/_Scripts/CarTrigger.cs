using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    public CarMove car;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        car.Move();

    }
}
