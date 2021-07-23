using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlock : MonoBehaviour
{
    private Vector3 mousePos;
    private Vector3 objectPos;
    public GameObject selector;
    public int size = 1;
    //public BlockObj block;
    GameObject go;

    // Update is called once per frame
    void Update()
    {




        if (Input.GetMouseButtonDown(0))
        {
            



            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                float x = hit.transform.gameObject.transform.position.x;
                float y = hit.transform.gameObject.transform.position.y;
                if (size == 2)
                {
                    Create2(x, y);
                    SetColor();
                }
                if (size == 1)
                {
                    Create1(x, y);
                    SetColor();
                }
                


                //Debug.Log("Click" + "x=" + x + "; y=" + y);
            }

        }
    }

    void Create1(float x, float y)
    {
        //mousePos = Input.mousePosition;
        //mousePos.z = 10.0f;
        //objectPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 objectPos = new Vector3(x, y, 0f);

        GameObject go = Instantiate(selector, objectPos, Quaternion.identity);
        go.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);
        go.transform.localScale = new Vector3(size, size, 1);
    }

    void Create2(float x, float y)
    {
        Vector3 objectPos2 = new Vector3(0, 0, 0);

        if (x <= 5 && y <= 5)
            objectPos2 = new Vector3(x + 0.5f, y + 0.5f, 0f);
        if (x > 5 && y > 5)
            objectPos2 = new Vector3(x - 0.5f, y - 0.5f, 0f);
        if (x <= 5 && y >= 5)
            objectPos2 = new Vector3(x + 0.5f, y - 0.5f, 0f);
        if (x >= 5 && y <= 5)
            objectPos2 = new Vector3(x - 0.5f, y + 0.5f, 0f);


        go = Instantiate(selector, objectPos2, Quaternion.identity);
        go.transform.localScale = new Vector3(size, size, 1);
        go.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.green);



    }

    public void SetColor()
    {
        
    }
}
