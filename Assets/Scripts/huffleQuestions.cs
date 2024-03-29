using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleQuestions : MonoBehaviour
{
    public GameObject[] Answers;

    void Start()
    {
        Shuffle(Answers);
    }

    public void Shuffle(GameObject[] gameObjects)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {

            int destIndex = Random.Range(0, gameObjects.Length);
            GameObject source = gameObjects[i];
            GameObject dest = gameObjects[destIndex];
            if (source != dest)
            {

                Vector3 tmp = source.transform.position;
                source.transform.position = dest.transform.position;
                dest.transform.position = tmp;
            }
        }
    }


}
