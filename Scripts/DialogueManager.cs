using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;

    public GameObject dialogueUI;
    public GameObject checkboxUI;

    public GameObject continueBtn;

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        if (sentences.Count == 3)
        {
            checkboxUI.SetActive(true);
            continueBtn.SetActive(false);
        }

        string sentence = sentences.Dequeue();
        Debug.Log("Dequeuing sentence: " + sentence);
        dialogueText.text = sentence;
    }

    public void dequeueNext()
    {
        sentences.Dequeue();
    }

    void EndDialogue()
    {
        Debug.Log("End of Dialogue");
        dialogueUI.SetActive(false);
    }
}
