using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    private static string key;
    private GameManager gm;
    
    private bool inside;

    void Start(){
        
        inside = false;
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    void Update(){

        if(!inside){
            switch(key){

                case "Alpha1":
                case "Alpha2":
                case "Alpha3":
                case "Alpha4":
                    gm.setScore(-10);
                    key = null;
                    break;

            }
        }

    }

    void OnGUI(){

        Event e = Event.current;

        if(e.isKey){

            key = e.keyCode.ToString();

        }

    }



    void OnTriggerStay(Collider collider){

        GameObject cube = collider.gameObject;

        inside = true;

        CheckCube(cube.tag, cube);

    }

    void CheckCube(string tag, GameObject cube){

        if(key.Equals(tag)){

            gm.setScore(15);

            gm.goodAudio();

            Destroy(cube);

            inside = false;

            key = null;

        }

    }

}
