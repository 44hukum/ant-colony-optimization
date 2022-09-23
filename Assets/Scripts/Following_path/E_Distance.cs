using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_Distance : MonoBehaviour
{
    public GameObject obj1,obj2;
    float distance;
    float obj1_x, obj1_y, obj1_z, obj2_x, obj2_y, obj2_z;
    // Start is called before the first frame update
    void Start()
    {
        float cost = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        Debug.Log(cost);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
