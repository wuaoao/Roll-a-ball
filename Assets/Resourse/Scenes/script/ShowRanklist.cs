using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowRanklist : MonoBehaviour {


    // Use this for initialization
    public Text[] timeText = new Text[10];
    public Text[] username = new Text[10];

    void Start () {
        RanklistData.rd.SortList();
        int ii = 0;
        foreach (RanklistData.rankdata s in RanklistData.rd.r)
        {
            username[ii].text = s.getname();
            timeText[ii].text = s.gettime().ToString();
            ii++;
            if (ii >= 10)
                break;
        }
        for(int i=ii;i<10;i++)
        {
            username[i].text = "----";
            timeText[i].text = "----";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
