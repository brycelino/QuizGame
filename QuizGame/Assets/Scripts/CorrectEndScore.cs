using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectEndScore : MonoBehaviour
{
    Text Correct; 
    // Start is called before the first frame update
    void Start()
    {
        Correct = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Correct.text = "Amount Correct: " + GameManager.instance.wrongScore;
    }
}
