using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float time;
    public static bool srt;

    void Start()
    {
        time = 0;
        srt = false;
    }

    void Update()

    {

        if (srt)

        {
            time += Time.deltaTime;
        }

    }
    public void stopbutton()
    {
        srt = false;
    }
    public static void resetbutton()
    {
        srt = false;
        time = 0;
    }
    public static void startbutton()
    {
        srt = true;
    }
}