﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
        // Debug.Log("Name " + name);
        //  Debug.Log("x pos " + transform.position.x);
        // assign position 0,0,0
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.right * Time.deltaTime * speed); // "speed" meters per second
    }

    // --> stopped at 015
}
