using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckboxManager : MonoBehaviour
{
    public int boxesChecked = 0;
    public int boxesRequired = 3;

    public GameObject checkboxUI;
    public GameObject continueBtn;
    public GameObject dialogueContinueBtn;

    public Toggle[] checkboxes; // added in editor

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < checkboxes.Length; i++) {
            Toggle temp = checkboxes[i]; // getting around variable capture

            checkboxes[i] = checkboxes[i].GetComponent<Toggle>();
            checkboxes[i].onValueChanged.AddListener(delegate {
                UpdateBoxesChecked(IsActive(temp));
                TryContinue();
            });
        }
    }

    private bool IsActive(Toggle t)
    {
        return t.isOn;
    }

    private void UpdateBoxesChecked(bool isActive)
    {
        if (isActive == true)
            boxesChecked++;
        else
            boxesChecked--;
    }

    private void TryContinue()
    {
        if (boxesChecked == boxesRequired)
            continueBtn.SetActive(true);
        else
            continueBtn.SetActive(false);
    }

    public void EndCheckbox()
    {
        Debug.Log("End Checkbox");
        checkboxUI.SetActive(false);
        dialogueContinueBtn.SetActive(true);
    }
}
