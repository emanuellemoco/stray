using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PasswordController : MonoBehaviour
{ 

    public Text digits;

    public GateLogic logic;

    public List<GameObject> buttons = new List<GameObject>();

    List<int> password = new List<int>();
    List<int> truePassword; //= new List<int>();
    void Start(){
        truePassword = new List<int>( new int[] {2,5,1,8,2,2});

    }

    void Update(){

    }

    public void buttonPressed(int number){

        if (number == -1 )
            checkAnswer();

        else if (number == -2){
            password.Clear();
            digits.text = "";
        }
        else if (password.Count == truePassword.Count )
            return;
        else {
            password.Add(number);
            digits.text += "*";
        }

    }

    void checkAnswer(){
        print("Check answer");
        if (CheckMatch(password, truePassword)){
            print("IS EQUAL");
            openDoor();
        }
        else {
            password.Clear();
            digits.text = "";
        }
    }

    void openDoor(){
        digits.color = Color.green;
        logic.openDoor();
        //endgame.SetActive(true);

    }

    bool CheckMatch(List<int> l1, List<int> l2) {
        if (l1.Count != l2.Count){
            return false;
        }
        for (int i = 0; i < l1.Count; i++) {
            print(l1[i] == l2[i]);
            if (l1[i] != l2[i])
                return false;
        }
        return true;
        }
}