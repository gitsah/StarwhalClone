using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("memes");
	}

    // Update is called once per frame
    void Update() {
        Quaternion rot = transform.rotation;
        Vector3 pos = transform.position;


        if (Input.GetKey(KeyCode.LeftArrow)) { 
            rot.z += 0.002f;
            pos.y += 0.09f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rot.z -= 0.002f;
            pos.y -= 0.09f;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.x += 0.09f;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.x -= 0.09f;

        }

        transform.rotation = rot;
        transform.position = pos;
	}
}
