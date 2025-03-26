using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    private bool playerDetected;
    //detect trigger with player
    private void OnTriggerEnter(Collider other) {
        //if  on trigger the player unable player detecter and show indicator
        if(other.CompareTag("Player")) {
            //show indicator
            ToggleIndicator(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if  on trigger the player unable player detecter and show indicator
    }
    //if detected show chracter
    //if not detected hide indicator
    //while detected if we interact start the dialogue
}
