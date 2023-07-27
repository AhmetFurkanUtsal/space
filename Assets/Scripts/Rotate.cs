using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vek3;
    // Start is called before the first frame update
    void Start()
    {
        vek3 = new Vector3(0,0.3f,0);  
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (vek3);
        
    }
}
