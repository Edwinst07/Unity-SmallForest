using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot_Hour : MonoBehaviour
{
    private float z = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z += Time.deltaTime * 0.5f;
        transform.rotation = Quaternion.Euler(0, 0, z);
        
    }
}
