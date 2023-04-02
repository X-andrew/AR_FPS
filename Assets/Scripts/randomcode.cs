// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.IO.Ports;

// // make sure to name your C# file the same as your class name. In this case Move.cs 
// public class randomcode : MonoBehaviour
// {
//     // change your serial port
//     SerialPort sp = new SerialPort("COM4", 9600);
    
//     // Start is called before the first frame update
//     void Start()
//     {
//         sp.Open();
//         sp.ReadTimeout = 100; // In my case, 100 was a good amount to allow quite smooth transition. 
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (sp.IsOpen){
//             try{
//                 // When left button is pushed
//                 if(sp.ReadByte()==0){
//                     print(sp.ReadByte());
//                     Debug.Log(sp.ReadByte());
//                     transform.Translate(Vector3.left * Time.deltaTime * 5);
//                 }
//                 // When right button is pushed
//                 if(sp.ReadByte()==1){
//                     print(sp.ReadByte());
//                     Debug.Log(sp.ReadByte());
//                     transform.Translate(Vector3.right * Time.deltaTime * 5);
//                 }
//             }
//             catch (System.Exception){
               
//             }

//         }
//     }
// }





 using UnityEngine;
 using System.Collections;
 using System.IO.Ports;
 
 public class randomcode : MonoBehaviour {
     SerialPort sp = new SerialPort("COM4", 9600);
     public Transform t;
     public GameObject obj;
     float x,y,xaxis,yaxis;

     int check;
     int z = 0;
     bool f = true, fx = true , fy= true;
         private void gayab()
    {
        obj.SetActive(false);
        // Debug.Log(count);
        //t.text = "Count :" + count;


    }
    
     void Start () {
         sp.Open ();
         sp.ReadTimeout = 25;
     }
 
     void Update () 
     {
         try{
             //print (sp.ReadLine());
             Debug.Log(sp.ReadLine());
             string received = sp.ReadLine();
             string[] datas = received.Split(',');
             x = float.Parse(datas[0]);
             y = float.Parse(datas[1]);
            check = int.Parse(datas[2]);
            
             

         }
         catch(System.Exception){
         }
         if(Vector3.Distance(obj.transform.position , t.position)<=1f & check==0) gayab();


         xaxis = x/1000;
         yaxis = y/1000;
        //  t.position = Vector3(xaxis,yaxis,t.position.z);
        // transform.Translate(Vector3.left * Time.deltaTime * xaxis);
        // transform.Translate(Vector3.up * Time.deltaTime * yaxis);
        // pointer.position = new Vector3(xaxis,yaxis,pointer.position.z);
        //t.position = new Vector3(0,0,0);
        
        
         if(fx) t.position += new Vector3(xaxis,0f,0f);
            
        
        else t.position -= new Vector3(xaxis,0f,0f);
        if(t.position.x < 5.0f) fx = false;
        if(t.position.x > -5.0f) fx = true;
        
         if(fy) t.position += new Vector3(0f,yaxis,0f);
            
        
        else t.position -= new Vector3(0f,yaxis,0f);
        if(t.position.y < 5.0f) fy = false;
        if(t.position.y> -5.0f) fy = true;
         
     }

 }