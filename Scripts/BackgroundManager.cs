using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject blue;
    public GameObject red;
    public BombTiming bombTiming;
    void Update()
    {
        if (bombTiming.timed == false)
        {
            red.SetActive(true);
            blue.SetActive(false);
        }
        else 
        {
            red.SetActive(false);
            blue.SetActive(true);
        }
    }
}
