using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public PlayerControl playControl;

    void Start()
    {
        playControl = FindObjectOfType<PlayerControl>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playControl.SetSpawnPoint(transform.position);
        }
    }
}
