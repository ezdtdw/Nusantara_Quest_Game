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
    private GameObject DialogueCanvas;

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

    private bool DialgoueActivated;

    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.E) /*&& isGrounded*/ && DialgoueActivated == true){ 
            DialogueCanvas .SetActive(true);
            spreakerText.text = speaker[0];
            dialogueText.text = dialogueWords[0];
            portraitImage.sprite = portrait[0];
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "Player"){
            DialgoueActivated = true;
        }
    }

        void OnTriggerExit2D(Collider2D collision) {
            if (collision.gameObject.tag == "Player") {
                DialgoueActivated = false;
                if (DialogueCanvas != null) {
                    DialogueCanvas.SetActive(false); // Pastikan hanya dipanggil jika objek masih ada
                }
            }
        }
}
