using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Advance Dialogue", menuName = "ScriptableObjects/Advance Dialogue SO")]
public class AdvanceDialogueSO : ScriptableObject
{
    //public DialogueActorSO[] actors;

    [Tooltip("Only need if Randoom is selected as the actor name")]
    [Header("Random Actor Info")]
    public string[] randomActorName;
    public Sprite[] randomActorPortrait;

    [Header("Dialogue")]
    [TextArea]
    public string[] dialogue;

    
    [Tooltip("The words tht will appear on option buttons")]
    public string[] optionText;

    public AdvanceDialogueSO option0;
    public AdvanceDialogueSO option1;
    public AdvanceDialogueSO option2;
    public AdvanceDialogueSO option3;
}
