using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public GameObject dialogueUI;

    public void TriggerDialogue()
    {
        dialogueUI.SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
