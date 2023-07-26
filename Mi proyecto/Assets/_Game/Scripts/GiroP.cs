using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroP : MonoBehaviour
{
    public int id;
    Vector3 rotacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(id == 1)
        {
            rotacion = new Vector3(15, 30, 45);
            transform.Rotate(rotacion * Time.deltaTime);

        }else if(id == 2)
        {
            rotacion = new Vector3(0, 45, 0);
            transform.Rotate(rotacion * Time.deltaTime);
        }

        
    }


}
