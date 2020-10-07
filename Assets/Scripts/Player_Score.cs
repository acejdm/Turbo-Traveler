using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    //private float timeLeft = 200;
    public int playerScore = 0;
    public int moneyCount = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public GameObject moneyCountUI;
    public AudioSource coinSound;
    public AudioSource hitSound;
    public AudioSource clearSound;
    //float Reset;
    //float delay = 3;

    void Start()
    {
        DataManagement.datamanagement.LoadData();
    }


    // Update is called once per frame
    void Update()
    {
        //timeLeft -= Time.deltaTime;
        //timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        //playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        moneyCountUI.gameObject.GetComponent<Text>().text = ("Money Count: " + moneyCount);
        /* if (timeLeft < 0.1f)
        {
            SceneManager.LoadScene("Prototype 1");
       */ }
    

    private void OnTriggerEnter(Collider trig)
    {
        /* if (trig.gameObject.tag == "EndLevel")
        {
            clearSound.Play();
            CountScore();
            DataManagement.datamanagement.SaveData();
            SceneManager.LoadScene("Prototype 2");
        }*/
        if (trig.gameObject.tag == "coin")
        {
            playerScore += 10;
            moneyCount += 1;
            Destroy(trig.gameObject);
            coinSound.Play();
        }
/*if (trig.gameObject.tag == "coinSilver")
        {
            playerScore += 20;
            Destroy(trig.gameObject);
            coinSound.Play();
        }*/

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            playerScore += 5;
            Destroy(other.collider.gameObject);
            hitSound.Play();
        }
    }


    /*void CountScore()
    {
        playerScore = playerScore + (int)(timeLeft * 10);
        DataManagement.datamanagement.highScore = playerScore + (int)(timeLeft * 10);
        DataManagement.datamanagement.SaveData();
    }*/
}


