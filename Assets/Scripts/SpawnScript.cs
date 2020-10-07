using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
    //this is where you declare your variables:
    public GameObject prefabToSpawn;
    public float timer;
    public float timerOG; //this is what the timer will revert to
    //A Vector3 is a coordinate point in
    //three dimensions (0,10,5)
    public Vector3 spawnPos;
    public int coinLimit = 5;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        //timer = timer - Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0 && coinLimit>0)
        {
            if (coinLimit == 1)
            {
                coinLimit = 5;
            }
            Instantiate(prefabToSpawn, new Vector3(spawnPos.x,spawnPos.y, spawnPos.z+coinLimit), Quaternion.identity);
            timer = timerOG;
            coinLimit--; //-- is a shortcut to decrement an int/float
        }
    }
}
