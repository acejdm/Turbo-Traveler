using System.Collections;
using System.Collections.Generic;
using System.Globalization;

using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    void Update()
    {
        if(LapsDone == 1)
        {
            RaceFinish.SetActive(true);
        }

        if(LapsDone == 2)
        {
            RaceFinish.SetActive(true);
        }
       
    }

    void OnTriggerEnter()
    {
        LapsDone += 1;
       
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if (LapTimeManeger.RawTime <= RawTime)
        {
            if (LapTimeManeger.SecondCount <= 9)
            {
                SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManeger.SecondCount + ".";

            }
            else
            {
                SecondDisplay.GetComponent<Text>().text = "" + LapTimeManeger.SecondCount + ".";
            }
            if (LapTimeManeger.MinuteCount <= 9)
            {
                MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManeger.MinuteCount + ".";

            }
            else
            {
                MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManeger.MinuteCount + ".";
            }

            MilliDisplay.GetComponent<Text>().text = "" + LapTimeManeger.MilliCount;
        }
        PlayerPrefs.SetInt(" MinSave", LapTimeManeger.MinuteCount);
        PlayerPrefs.SetInt(" SecSave", LapTimeManeger.SecondCount);
        PlayerPrefs.SetFloat(" Milli Save", LapTimeManeger.MilliCount);
        PlayerPrefs.SetFloat("RawTime", LapTimeManeger.RawTime);

        LapTimeManeger.MinuteCount = 0;
        LapTimeManeger.SecondCount = 0;
        LapTimeManeger.MilliCount = 0;
        LapTimeManeger.RawTime = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

    }
   
}
