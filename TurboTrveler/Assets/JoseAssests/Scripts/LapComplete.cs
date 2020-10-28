using System.Collections;
using System.Collections.Generic;

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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
        
       
    {
        LapsDone += 1;
        if(LapTimeManeger.SecondCount <= 9)
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

      
        LapTimeManeger.MinuteCount = 0;
        LapTimeManeger.SecondCount = 0;
        LapTimeManeger.MilliCount = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;
        HalfLapTrig.SetActive (true);
        LapCompleteTrig.SetActive(false);
    }
}
