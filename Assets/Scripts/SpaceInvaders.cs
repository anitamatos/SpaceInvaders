using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceInvaders : MonoBehaviour
{    
    [SerializeField]
    GameObject[] invasores; 

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5F;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;

    void Awake()
    { // pega neste objeto, duplica e coloca-o "naquela" posição
        
        float y = yMin;

        for (int line= 0; line < 7; line++)
        {
           
            float x = xMin;
            for (int i = 1; i <= nInvasores; i++)
            {
                GameObject newInvader = Instantiate(invasores[line], transform);
                newInvader.transform.position = new Vector3(x, y, 0f);
                x += xInc;
            }
            y += yInc;

        }


        

    }    
       
}
