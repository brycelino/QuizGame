using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class endingscore : MonoBehaviour
{
    
    Text Wrong;
    // Start is called before the first frame update
    void Start()
    {
        
        Wrong = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Wrong.text = "Amount Wrong: " + GameManager.instance.wrongScore;
    }
}
