using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    //fields

     //windows
    public GameObject window;
    //indicator
    public GameObject indicator;
    //text component
    public TMP_Text dialogueText;
    //dialogue
    public List<string> dialogues;
    //index on dialogue
    private int index;
    //character index
    private int charIndex;
    //started bolean
    private bool started;



    private void ToggleWindow(bool show) {
        //toggle the window
        window.SetActive(show);
    }

    private void ToggleIndicator(bool show) {
    //toggle the window
    indicator.SetActive(show);
    }

    //start dialog
    public void StartDialogue() {
        if(started) return; 
        //bolean to idcated taht we have starte
        started = true;
        //show the window
        ToggleWindow(true);
        //hide the indicator
        ToggleIndicator(false);
        //start with first dialogue
        GetDialogue(0);
    }

    //end dialogue
    private void GetDialogue(int i){
        //start index at zero
        index = i;
        //reset the character index
        charIndex = 0;
        //start writeing
        StartCoroutine(writing());
    }
    public void EndDialogue() {
        //hide the window

    }


    //writing logic
    IEnumerator writing(){
        String currentDialogue = dialogues[index];
        //write the character

        //increase the character index
        //wait x seconds
        //restart the same process
    }
}
