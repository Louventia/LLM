using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionController : MonoBehaviour
{
    public Animator transition;

    public float trans_Time = 1f;

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) // need to change, this is for testing purposes.
        {
            Load_Next_Scene();
        }
        
        
    }

    public void Load_Next_Scene()
    {
        StartCoroutine(Load_Scene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator Load_Scene(int level_Index)
    {
        // Animation:
        transition.SetTrigger("End");

        // Delay:
        yield return new WaitForSeconds(trans_Time);

        // Load:
        SceneManager.LoadScene(level_Index);

    }



}
