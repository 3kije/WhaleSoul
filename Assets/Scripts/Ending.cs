using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    public float transitionTime = 5f;
    public GameObject WhaleCanvas;
    public GameObject SoulCanvas;



    public void Whale()
    {
        WhaleCanvas.SetActive(true);
     
        LoadNextLevel();
    }

    public void Soul()
    {
        SoulCanvas.SetActive(true);
        
        LoadNextLevel();
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
