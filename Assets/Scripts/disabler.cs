using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disabler : MonoBehaviour
{
    public GameObject Incorrect1;
    public GameObject Incorrect2;
    public GameObject Next;
    public GameObject CorrectAnswer;
  

    void Start()
    {
        Next.GetComponent<Button>().interactable = false;
    }


    public void clickAnswer()
    {
        CorrectAnswer.GetComponent<Button>().interactable = false;
        CorrectAnswer.GetComponent<Image>().color = Color.green;
        Incorrect1.GetComponent<Button>().interactable = false;
        Incorrect1.GetComponent<Image>().color = Color.red;
        Incorrect2.GetComponent<Button>().interactable = false;
        Incorrect2.GetComponent<Image>().color = Color.red;
        Next.GetComponent<Button>().interactable = true;
    }

}
