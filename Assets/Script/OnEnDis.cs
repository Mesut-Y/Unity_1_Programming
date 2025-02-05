using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnDis : MonoBehaviour
{

    public float delay = 3f;
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("on enable metodu çalýþtý.");
        Invoke("Caller", delay);//3sn içinde caller metodunu çaðýracak
    }

    // Update is called once per frame
    void OnDisable()
    {
        Debug.Log("on disable metodu çalýþtý.");
    }

    private void Caller()
    {
        this.gameObject.SetActive(false);   //this olmasada nesneyi etkilediðini anlar.
    }
}
