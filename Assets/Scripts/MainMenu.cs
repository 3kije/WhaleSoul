using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class MainMenu : MonoBehaviour
{

    ///public Animator transition;


    public float transitionTime = 10f;

    public PlayableDirector director;


   

    public void StartTimeline()
    {
        director.Play();
    }


    public void PlayGame()
    {
        StartTimeline();
        LoadNextLevel();


    }

    public void QuitGame()
    {
        Debug.Log("Quit!!");
        Application.Quit();
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
