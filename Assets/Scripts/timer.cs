using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField] Text countdownText; 

    void Strat()
    {
        currentTime -= startingTime; 

    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;     
    }
}
