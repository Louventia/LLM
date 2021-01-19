using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    // Variables:
    public GameObject yes_Option;
    public GameObject no_Option;
    public GameObject any_Button;

    private bool scene_Ready; // supposedly for the checklist but idk how to further branch out


    void Start()
    {
        yes_Option.SetActive(false);
        no_Option.SetActive(false);

    }

    void Update()
    {

        Any_Key();

    }


    public void Any_Key() // to test this function again
    {
        if (Input.anyKeyDown)
        {
            any_Button.SetActive(true);
            Destroy(this.any_Button);
        }

    }

    public void Quit_Button()
    {
        Application.Quit();
    }

    public void Yes_Button() // not sure if this is contradicting.
    {
        yes_Option.SetActive(true);
        no_Option.SetActive(false);
    }

    public void No_Button()
    {
        no_Option.SetActive(true);
        yes_Option.SetActive(false);
    }

}
