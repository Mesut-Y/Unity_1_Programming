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
            Debug.Log("Sava��� k�l�� ile sald�r�yor.");

        }
    }

    public class Mage: ICombat , iMeditation
    {
        public void Attack()
        {
            Debug.Log("B�y�c� b�y� ile sald�r�yor.");
        }

        public void ManaReturn()
        {
            Debug.Log("B�y�c� meditasyon yap�yor.");
        }
    }

