using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockObj : MonoBehaviour
{
    public Color Color { get; set; } = Color.green;
    public int Size { get; set; }



    //public GameObject selector;

    //public BlockObj()
    //{

    //}

    public void Update()
    {
       // GetComponent<MeshRenderer>().material.SetColor("_Color", Color);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Block"))
        {
            other.transform.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            //Color = Color.red;
            Debug.Log("COLLIDE!!!");
        }
    }

    //void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.CompareTag("Block"))
    //    {
    //        Color = Color.red;
    //        Debug.Log("COLLIDE!!!");
    //    }
    //}
}
