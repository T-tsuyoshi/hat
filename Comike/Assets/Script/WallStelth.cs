using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStelth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.B) == true)
        {
            //isTriggerをtrueにしてすり抜けられるようにする
            this.GetComponent<BoxCollider2D>().isTrigger = true;
        }
        else
        {
            //isTriggerをfalseにしてすり抜けられないようにする
            this.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }
}
