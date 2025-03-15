using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private TMP_Text spreakerText;
    [SerializeField]
    private TMP_Text dialogueText;
    [SerializeField]
    private Image portraitImage;

    ///Dialog contentn
    [SerializeField]
    private string[] speaker;
    [SerializeField]
    [TextArea]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;

    private bool dialogueActive;

    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update() {

        if(Input.GetKeyDown(KeyCode.E) /*&& isGrounded*/) {
            spreakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
        }
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            dialogueActive = true;
        }
    }
}
