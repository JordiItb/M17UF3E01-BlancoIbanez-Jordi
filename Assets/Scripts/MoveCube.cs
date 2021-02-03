using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    private GameManager gm;

    void Start(){

        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {
        
        transform.localPosition += new Vector3(10f, 0f, 0f) * Time.deltaTime;

        if(transform.position.x > 10f){

            DestroyCube();

            gm.setScore(-10);

            gm.badAudio();


        }

    }

    public void DestroyCube(){

        Destroy(this.gameObject);

    }
}
