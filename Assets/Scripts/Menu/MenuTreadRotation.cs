using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTreadRotation : MonoBehaviour
{
    private float timer, cooldown = 1;

    private int rotationAmount = 1;

    [SerializeField]
    private GameObject textFront, textBack;
    
    void Awake()
    {
        textBack.GetComponent<TextMesh>().text = "HiScore:  " + PlayerPrefs.GetInt("HiScore");
        
        timer = Time.timeSinceLevelLoad + cooldown * 2;
    }
    void Update()
    {
        if (Time.timeSinceLevelLoad  > timer)
        {
            transform.Rotate(new Vector3(0,45,0));
            rotationAmount++;
            timer = Time.timeSinceLevelLoad  + cooldown;
            
            
            if (rotationAmount % 5 == 0)
            {
                textFront.SetActive(!textFront.activeSelf);
                textBack.SetActive(!textFront.activeSelf);
            
                rotationAmount -= 4;
            }
        }
        
    }
}
