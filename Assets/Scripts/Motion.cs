using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO.Ports;
public class Motion : MonoBehaviour
{
    public float speedx = 3.0f; 
    public float speedy = 5.0f;
    // public TMP_Text t;
    bool f = true;
    bool fx = true;
    bool fy = true;
    //public GameObject obj;
    //public  GameObject pointer;
    float x,y;
    int count = 0;
    void Start()
    {
       // t = GetComponent<TMP_Text> ();
    }

    private void reversex()
    {
        transform.position += new Vector3(speedx * Time.deltaTime*(-1), 0, 0);

    }
    private void forwardx()
    {
        transform.position += new Vector3(speedx * Time.deltaTime, 0, 0);
    }
    private void reversey()
    {
        transform.position += new Vector3(0,speedy * Time.deltaTime*(-1), 0);

    }
    private void forwardy()
    {
        transform.position += new Vector3(0,speedy * Time.deltaTime, 0);
    }
    void Update()
    {
        
        //     Console.Write(Mathf.Abs(pointer.position.x - transform.position.x));
        // if(Mathf.Abs(pointer.position.x - transform.position.x) <= 0.1f && Mathf.Abs(pointer.position.y - transform.position.y) <= 0.1f ) gayab();


        //  x = Vector3.Distance(new Vector3(obj.transform.position.x, 0f , 0f), new Vector3(pointer.transform.position.x, 0f, 0f));
        //  y = Vector3.Distance(new Vector3(0f, obj.transform.position.y, 0f), new Vector3(0f, pointer.transform.position.y, 0f));
        // if(Mathf.Abs(x)<=0.1f && Mathf.Abs(y)<=0.1f) gayab();
        
       // Debug.Log(Vector3.Distance(obj.transform.position , pointer.transform.position));
        if(fx) forwardx();
            
        
        else reversex();
        if(transform.position.x >= 5) fx = false;
        if(transform.position.x <= -5) fx = true;
        
         if(fy) forwardy();
            
        
        else reversey();
        if(transform.position.y >= 5) fy = false;
        if(transform.position.y <= -5) fy = true;
        
    }

}