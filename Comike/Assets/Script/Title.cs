using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    public GameObject Obj;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Cursor cursor = Obj.GetComponent<Cursor>();
        if (Input.GetKey(KeyCode.Space) &&
            cursor.ReturnCursorY() == -1){
            SceneManager.LoadScene("Game");
        }
		
	}
}
