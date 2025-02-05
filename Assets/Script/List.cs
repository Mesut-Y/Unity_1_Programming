using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> inventory = new List<string>();

        inventory.Add("Sword");
        inventory.Add("Helmet");
        inventory.Add("Axe");
        inventory.Add("Potion");

        print(inventory[0]);

        print(inventory.Count); //list eleman say�s�

        inventory.Remove("Potion");

        print(inventory.Count);

        inventory.Insert(3, "Potion"); //liste eleman eklemek
        
        foreach(string item in inventory)  //listeyi yazd�rma
        {
            print(item);
        }

        inventory.Sort(); //listeyi s�ralama
        foreach (string item in inventory)
        {
            print(item);
        }

        inventory.Reverse(); //listeyi tersine �evirme
        foreach (string item in inventory)
        {
            print(item);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
