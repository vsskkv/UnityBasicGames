using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    //Var's
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start(){
        StartGame();
    }

    void StartGame() {

        max = 1000;
        min = 1;
        guess = 500;

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
            NextGuess("lower");
            Debug.Log(guess);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess("higher");
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Restarting.....");
            StartGame();
        }
    }

    void NextGuess(string dir) {
        guess = (max + min) / 2;
        Debug.Log("number is " + dir);
    }
}
