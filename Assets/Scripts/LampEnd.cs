using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LampEnd : MonoBehaviour
{
    private int clicksCountdown;
    public float transitionTime = 3f;

    void Start()
    {
        clicksCountdown = 3;
    }


   public void OnMouseDown()
    {

        clicksCountdown -= 1;

        if (clicksCountdown < 1)
        {
           
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        // transition.SetTrigger("Start");


        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
