using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class Door : MonoBehaviour
{

    private int clicksCountdown;
    public float transitionTime = 5f;
   
    public PlayableDirector director;


    // Start is called before the first frame update
    void Start()
    {
        clicksCountdown = 3;
    }

    public void StartTimeline()
    {
        director.Play();
    }


    private void OnMouseDown()
    {
       
        clicksCountdown -= 1;

        if (clicksCountdown < 1)
        {
            StartTimeline();
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

        //SceneManager.LoadScene(levelIndex);
        SceneManager.LoadScene("04_Credits");
    }
}
