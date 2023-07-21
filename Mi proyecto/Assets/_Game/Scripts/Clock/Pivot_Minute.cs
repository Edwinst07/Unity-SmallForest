using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot_Minute : MonoBehaviour
{
    float z = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 rot = new Vector3(0, 0, 10f);
        //transform.Rotate(rot * Time.deltaTime * 10f);

        z += Time.deltaTime * 5f;
        transform.rotation = Quaternion.Euler(0, 0, z);
        
    }
}
