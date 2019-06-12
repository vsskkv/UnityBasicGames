using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AdventureGame : MonoBehaviour
{
    //var
    //SerializeField means that its in the inspector
    [SerializeField] Text textComponent; 


    // Start is called before the first frame update
    void Start(){
        textComponent.text = ("Start Game");
    }

    // Update is called once per frame
    void Update(){
        
    }
}
