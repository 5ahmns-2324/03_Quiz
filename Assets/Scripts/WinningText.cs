using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinningText : MonoBehaviour
{
    public GameObject FinishedCanvas;
    public GameObject QuestionCanvas;
    
    

    public int Points;
    public void addWinner()
    {
       Points++;
    }

    void Start()
    {
        QuestionCanvas.SetActive(true);
        FinishedCanvas.SetActive(false);
        
    }
    
    void Update()
    {
        if (Points == 5)
        {
            QuestionCanvas.SetActive(false);
            FinishedCanvas.SetActive(true);

        }

    }
}
