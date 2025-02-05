using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sınıf_Kal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    Car car1=new Car();
    MotorCyle cyle1= new MotorCyle();

        car1.color = "red";
    car1.Drive();
    // cyle1.dr  motor vehicle sınıfından kalıtım almadığı için vehicle ait sınıf ve değişkenleri kullanamıyor.

    }

    // Update is called once per frame
    void Update()
    {
        
    }

public abstract class Vehicle   //abstract olursa class türetilemez yapar. ama alt sınıflar yine türetir.
{
    public string color;
    public int modelYear;

    public virtual void Drive()   //polimorphizm için virtual tamamen sanal yaptık.
    {
        Debug.Log("araba gidiyor.");

    }
}
    public class Car : Vehicle
    {
        public int headLight = 2;

        public override void Drive()  //override sayesinde üst sınıfın metodunu ezdi.
        {
            Debug.Log("araba 4 teker üzerinde gidiyor.");
        }
    }
    
    public class MotorCyle 
    {
    public int headLight = 1;
    }
    
}
