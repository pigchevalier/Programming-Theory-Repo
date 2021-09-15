using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    
    public float width;
    public float heigth;
    protected abstract void SetSize(float lenth);
    protected abstract void SetSize(float width,float heigth);
}
