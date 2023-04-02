// using UnityEngine;
// using System.Collections ;
// using System.IO.Ports ;



// public class connect : MonoBehaviour
// {
//     SerialPort data_stream = new SerialPort( "COM7",19200) ;
// public string receivedstring;
// public GameObject test_data;
// public Rigidbody rb;
// public float sensitivity = 0.01f;

// public string[] datas;

// void Start()
// {
// data_stream.Open() ;
// }

// void Update()
// {

// receivedstring = data_stream.ReadLine();

// string[] datas = receivedstring.Sp1it(' , '); //split the data between
// rb.AddForce(0, 0, float.Parse(datas[0])* sensitivity * Time.deltaTime, ForceMode.VelocityChange);
// rb.AddForce(f10at.Parse(datas[1]) * sensitivity * Time.deltaTime, 0, 0, Forcemode.VelocityChange);
// transform.Rotate(0, float.Parse(datas[2]), 0);
// }



using UnityEngine;
using System.Collections;
public class connect : MonoBehaviour
{
    public SerialController s;
    void Start()
    {
        s = GameObject.Find("SerialController").GetComponent<SerialController>();
    }
    void Update()
    {
        var x = s.ReadSerialMessage();
//        Debug.Log(x);


    }
}



// using UnityEngine;
//  using System.Collections;
//  using System.IO.Ports;
 
//  public class connect : MonoBehaviour {
//      SerialPort sp = new SerialPort("COM4", 9600);
 
//      void Start () {
//          sp.Open ();
//          sp.ReadTimeout = 1;
//      }
 
//      void Update () 
//      {
//          try{
//              print (sp.ReadLine());
//          }
//          catch(System.Exception){
//          }
//      }
//  }