using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour {

    public static UserData ud;
    private string name;
    private double finaltime;

    private void Awake()
    {
        if (ud == null)
        {
            DontDestroyOnLoad(gameObject);
            ud = this;
        }
        else if (ud != null)
        {
            Destroy(gameObject);
        }
    }

    public void setname(string n)
    {
        name = n;
    }

    public string getname()
    {
        return name;
    }

    public void setftime(double n)
    {
        finaltime = n;
    }

    public double getftime()
    {
        return finaltime;
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
