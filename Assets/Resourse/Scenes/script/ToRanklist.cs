﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRanklist : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Press()
    {
        bool flag = false;
        if (!flag)
        {
            //password.text = count.ToString();
            Application.LoadLevel("Ranklist");
        }

    }
}