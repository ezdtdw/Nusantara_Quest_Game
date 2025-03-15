using System.Collections;
using System.Collections.Generic;
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
    private Image portraitImage;

    ///Dialog contentn
    [SerializeField]
    private string[] speaker;
    [SerializeField]
    private string[] dialogueWords;

    [SerializeField]
    private Sprite[] portrait;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
