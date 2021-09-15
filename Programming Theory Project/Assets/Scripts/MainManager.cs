using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    GameObject sphere;
    [SerializeField]
    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateSphere()
    {
        sphere.GetComponent<SphereManager>().s_Count = sphere.GetComponent<SphereManager>().Countdispl;
        for (int i = 0; i < sphere.GetComponent<SphereManager>().s_Count; i++)
        {
            Instantiate(sphere, new Vector3(0, 0, i * 5), sphere.transform.rotation);
            
        }
    }
    public void CreateCube()
    {
        Instantiate(cube, new Vector3(5, 0, 0), cube.transform.rotation);
    }
}
