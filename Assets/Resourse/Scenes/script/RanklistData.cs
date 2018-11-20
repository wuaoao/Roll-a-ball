using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RanklistData : MonoBehaviour {

    public static RanklistData rd;
    public class rankdata
    {
        string username;
        double ftime;
        public rankdata(string s,double d)
        {
            username = s;
            ftime = d;
        }
        public string getname()
        {
            return username;
        }

        public double gettime()
        {
            return ftime;
        }

        
    }
    public List<rankdata> r = new List<rankdata>();

    private int SortListCompare(rankdata a, rankdata b)
    {

        if (a.gettime() < b.gettime())
        {
            return -1;
        }
        else if (a.gettime() > b.gettime())
        {
            return 1;
        }
        return 0;
    }

    public void SortList()
    {
        r.Sort(SortListCompare);
    }

    private void Awake()
    {
        if (rd == null)
        {
            DontDestroyOnLoad(gameObject);
            rd = this;
        }
        else if (rd != null)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
