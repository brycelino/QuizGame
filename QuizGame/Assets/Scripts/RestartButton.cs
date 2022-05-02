using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void GoToTitle()
    {
        SceneManager.LoadScene(0);
        GameManager.instance.correctScore = 0;
        GameManager.instance.wrongScore = 0;
    }
}
