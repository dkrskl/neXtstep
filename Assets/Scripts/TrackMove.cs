using System.Collections;
using UnityEngine;

public class TrackMove : MonoBehaviour
{
    [SerializeField]
    private Vector3[] blockListPos;
    [SerializeField]
    private Quaternion[] blockListRot;
    
    private int amount = 1;

    

    void Awake()
    {
        for(int i=0; i < transform.childCount; i++)
        {
            blockListPos[i] = transform.GetChild(i).position;
            blockListRot[i] = transform.GetChild(i).rotation;

        }
    }

    public void RightRotate()
    {
        //Rotate the given array by n times toward right    
        for(int i = 0; i < amount; i++)
        {
            int j;
            Vector3 last;
            Quaternion lastRot;
            
            // --> Further blocks
            last = blockListPos[11];
            lastRot = blockListRot[11];
            
            for(j = 11; j > 0; j--){    
                //Shift element of array by one    
                blockListPos[j] = blockListPos[j-1];    
                blockListRot[j] = blockListRot[j-1];   
            }    
            //Last element of array will be added to the start of array.    
            blockListPos[0] = last;
            blockListRot[0] = lastRot;
            
            // --> Closer Blocks
            last = blockListPos[blockListPos.Length-1];    
            lastRot = blockListRot[blockListRot.Length-1];    
            
              for(j = blockListPos.Length-1; j > 12; j--){
                  blockListPos[j] = blockListPos[j-1];    
                  blockListRot[j] = blockListRot[j-1];    
              }
              blockListPos[12] = last;   
              blockListRot[12] = lastRot;   
        }


        UpdateBlocks();
    }
    

    void UpdateBlocks()
    {
        for (int i = 0; i < transform.childCount; ++i)
        {
            transform.GetChild(i).rotation = blockListRot[i];
            transform.GetChild(i).position = blockListPos[i];

            // Lame way to handle putting X s. Cba adding transforms this shit is easier.
            // Only bottom can be 4.8 PRECISELY so. lmfao
            if (transform.GetChild(i).localPosition.x == 4.8f && transform.GetChild(i).localPosition.y < -1)
            {
                if(i < 12)
                { 

                    int num = RandomGenerator.rnd.Next(100);
                    if (num < 50)
                    {
                        transform.GetChild(i).GetChild(1).gameObject.SetActive(true);
                        transform.GetChild(i+12).GetChild(1).gameObject.SetActive(false);
                    }
                    else
                    {
                        transform.GetChild(i+12).GetChild(1).gameObject.SetActive(true);
                        transform.GetChild(i).GetChild(1).gameObject.SetActive(false);
                    }
                    
                }
            }
            
        }
    }
        
}    
    

