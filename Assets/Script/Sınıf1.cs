using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sınıf1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Car car1 = new Car("Siyah", 2022);
        Car car2 = new Car("red",2018); //constructor kullanılarak nesne oluşturuldu.
        car2.Drive();

        /*Car car1=new Car();   constructor olmadan önce kullanılmıştır.
        Car car2=new Car();
        car1.modelYear = 2018;
        car1.color = "red";
        car1.Drive();

        car2.modelYear = 2022;
        car2.color = "black";
        car2.Horn();    constructor yapınca bu aşamalara gerek kalmadı. methodları sonradan oluşturabiliriz. */
        
    }


    public class Car
    {
        public string color;
        public int modelYear;

        public Car(string color, int modelYear) // constructor metod
        {
            this.color = color;
            this.modelYear = modelYear;
        }
        public void Horn()
        {
            Debug.Log("Düt Düt");
        }

        public void Drive()
        {
            Debug.Log(modelYear+"Model"+color+"renkli araba gidiyor.");
        }

    }
}
