using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class FinalOperation : MonoBehaviour {

    // Use this for initialization
    public Text finalText;

    void Start ()
    {
        finalText.text = "username:\t" + UserData.ud.getname() + "\n"
            + "finaltime:\t" + Math.Round(UserData.ud.getftime(), 4).ToString();
        RanklistData.rd.r.Add(new RanklistData.rankdata(UserData.ud.getname(), Math.Round(UserData.ud.getftime(), 4)));
        RanklistData.rd.SortList();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
