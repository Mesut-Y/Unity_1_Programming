using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinif_interface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Warrior warrior1 = new Warrior();
        Mage mage1 = new Mage();


        mage1.Attack();
        mage1.ManaReturn();


        warrior1.Attack();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
    public interface ICombat
    {
        void Attack();
    }

    public interface iMeditation
    {
        void ManaReturn();
    }

    public class Warrior: ICombat
    {
        public void Attack()
        {
            Debug.Log("Savaþçý kýlýç ile saldýrýyor.");

        }
    }

    public class Mage: ICombat , iMeditation
    {
        public void Attack()
        {
            Debug.Log("Büyücü büyü ile saldýrýyor.");
        }

        public void ManaReturn()
        {
            Debug.Log("Büyücü meditasyon yapýyor.");
        }
    }

