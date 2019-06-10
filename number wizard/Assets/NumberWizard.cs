using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Var
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Welcome to Number wizard, yo");
        Debug.Log("Pick a number...");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest is: " + min);
        Debug.Log("Tell me if its higher or lower than....  " + guess);
        Debug.Log("Push up arrow = higher, push down arrow = lower");
        max += 1;
    }


    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("number is lower");
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("number is higher");
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Return key was pressed.");
        }
    }
}
