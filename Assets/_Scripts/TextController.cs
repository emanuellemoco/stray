using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayMessage(string message){
        StartCoroutine(DisplayMessage(message));
    }

    IEnumerator DisplayMessage(string message)
    {
        text.text = message;
        yield return new WaitForSeconds(4.0f);
        text.text = "";

    }
}
