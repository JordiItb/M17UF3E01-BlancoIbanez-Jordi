using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] positions;
    public GameObject[] notes;
    private float cooldown;
    public float nextCooldown;

    void Start()
    {
        cooldown = 0f;
    }

    
    void Update()
    {
        
        if(Time.time > cooldown){

            SpawnBlocks();

            cooldown = Time.time + nextCooldown;

        }

    }

    void SpawnBlocks(){

        int obj = Random.Range(0, 4);

        Instantiate(notes[obj], positions[obj].position, Quaternion.identity);

    }
}
