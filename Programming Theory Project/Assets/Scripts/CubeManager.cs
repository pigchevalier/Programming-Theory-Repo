using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        if (width != heigth)
        {
            SetSize(width, heigth);
        }
        else
        {           
            SetSize(width);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void SetSize(float lenth)
    {
        transform.localScale += new Vector3(lenth, 2, 2);
    }

    protected override void SetSize(float width, float heigth)
    {
        transform.localScale += new Vector3(width, (width+heigth)/2, heigth);
    }
}
