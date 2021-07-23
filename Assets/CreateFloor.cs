using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFloor : MonoBehaviour
{
    public GameObject[] floor;

   // public GameObject[] selectorArr;
    public GameObject selector;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                GameObject go = Instantiate(selector, new Vector3(i, j, 0.5f), Quaternion.identity);
               
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
