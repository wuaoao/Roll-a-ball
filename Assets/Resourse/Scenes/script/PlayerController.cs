using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;
    
    public Text countText;
    public Text winText;
    public Text countNum;
    public Text timeText;
    public Text username;
    public Text CountDown;

    private double finaltime;
    private double starttime;
    private int count;
    private bool flag;

    void Start ()
    {
        rb=GetComponent<Rigidbody>();
        count=0;
        flag = false;
        username.text= UserData.ud.getname();
        setCountText();
    }

    void Update()
    {
        if(!flag)
        {
            timeText.text = "0";
            if(Time.timeSinceLevelLoad < 1)
            {
                CountDown.text = "3";
            }
            else if (Time.timeSinceLevelLoad < 2)
            {
                CountDown.text = "2";
            }
            else if (Time.timeSinceLevelLoad < 3)
            {
                CountDown.text = "1";
            }
            else
            {
                CountDown.text = "";
                flag = true;
                starttime = Time.timeSinceLevelLoad;
            }
        }
        if(flag)
            timeText.text = Math.Round(Time.timeSinceLevelLoad - starttime, 4).ToString();

    }

    void FixedUpdate ()
    {
        float moveHorizontal=Input.GetAxis ("Horizontal");
        float moveVertical=Input.GetAxis ("Vertical");

        Vector3 movement=new Vector3(moveHorizontal,0.0f,moveVertical);
        if(flag)
            rb.AddForce(movement*speed);
    }

    void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.CompareTag("pick_up"))
            {
                other.gameObject.SetActive(false);
                count++;
                setCountText();
            }
    }

    void setCountText()
    {
        countText.text="Count: "+count.ToString();
        countNum.text= count.ToString();
        if (count>=12)
        {
            finaltime = Time.timeSinceLevelLoad - starttime;
            winText.text="You Win!";
            flag = false;
            //winText.SetActive(true);
            UserData.ud.setftime(finaltime);
            Application.LoadLevel("WinScene");
        }
    }
}