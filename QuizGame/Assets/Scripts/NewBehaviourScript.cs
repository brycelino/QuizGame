using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public int nextScene;
    public void CorrectAnswer()
    {

        GameManager.instance.correctScore++;
    }

    public void WrongAnswer()
    {
        GameManager.instance.wrongScore++;
    }

    public void NextScene()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}
