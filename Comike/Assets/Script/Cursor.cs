using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    int y;

	// Use this for initialization
	void Start () {
        transform.position = Vector3.zero;
        transform.Translate(-5, -1, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.DownArrow) &&
            transform.position.y == -1)
        {
            // 座標移動
            transform.Translate(0, -3, 0);
            
        }
        else if (Input.GetKey(KeyCode.UpArrow) &&
            transform.position.y == -4)
        {
            // 座標移動
            transform.Translate(0, 3, 0);
        }

        
    }

    public int ReturnCursorY()
    {

        return (int)transform.position.y;
    }
}
