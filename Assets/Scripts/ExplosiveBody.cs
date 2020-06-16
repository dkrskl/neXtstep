using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBody : MonoBehaviour
{
    void Awake()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < transform.childCount; i+=2)
        {
            
            transform.GetChild(i).GetComponent<Rigidbody>().AddForce(new Vector3(RandomGenerator.GetRandomNumber(-2.5,2.5),RandomGenerator.GetRandomNumber(2,2),RandomGenerator.GetRandomNumber(-2.5,2.5)), ForceMode.Impulse);
        }
    }

}
