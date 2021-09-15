using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : Unit
{
    public int Countdispl; 
    private int count;
    public int s_Count
    {
        get { return count; }
        set 
        {
            if(value>0)
            {
                count = value;
            }
            else 
            {
                Debug.Log("value must be >0");
            }
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if(width==heigth)
        {
            SetSize(width);
        }
        else
        {
            SetSize(width, heigth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void SetSize(float lenth)
    {
        transform.localScale += new Vector3(lenth, 1, 1);
    }

    protected override void SetSize(float width, float heigth)
    {
        transform.localScale += new Vector3(width, 1, heigth);
    }
}
