using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigColli : MonoBehaviour
{

    public Renderer myObject;

    private void OnTriggerEnter()  //private isteðe baðlý
    {
        Debug.Log("tetiklenme tespit edildi.");
        //Destroy(this.gameObject);
        myObject.material.color = Color.red;
    }

    private void OnTriggerExit()
    {
        Debug.Log("tetiklenme tespit edildi.");
        myObject.material.color = Color.green;
    }

    private void OnCollisionEnter()
    {
        Debug.Log("Collision tespit edildi.");
        //myObject.material.color = Color.red;
    }








}
