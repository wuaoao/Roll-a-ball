using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Loading_animation : MonoBehaviour {

    public GameObject LoadingView;
    public Text Numtext;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Numtext.text = ((int)((Time.timeSinceLevelLoad - (int)Time.timeSinceLevelLoad) * 100)).ToString() + "%";
        if (Time.timeSinceLevelLoad >= 1)
        {
            LoadingView.SetActive(false);
        }
    }
}
