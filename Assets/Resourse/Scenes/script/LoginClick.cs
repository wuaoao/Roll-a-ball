using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginClick : MonoBehaviour {
    
    public Text username;
    public Text password;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Press()
    {
        bool flag = false;
        if(!flag)
        {
            UserData.ud.setname(username.text);
            //password.text = count.ToString();
            Application.LoadLevel("SampleScene");
        }
        
    }
    
}
