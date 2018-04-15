﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform hero;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - hero.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = hero.position + offset;
	}
}
