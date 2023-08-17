using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public float distance;
    public bool impact;
    private Rigidbody rb;
    private AnimationEnemy _animEnemy;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _animEnemy = Component.FindObjectOfType<AnimationEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        RayFeet();
    }


    private void RayFeet()
    {
        Debug.DrawRay(transform.position, Vector3.up * distance);
        Ray ray = new Ray(transform.position, Vector3.up * distance);
        RaycastHit hit;
        impact = Physics.Raycast(ray, out hit);
        if (impact && hit.collider.gameObject.tag=="Enemy")
        {
            Debug.Log("Estas encima del enemigo!!");
            hit.rigidbody.velocity = new Vector3(3,0,0);
            //hit.rigidbody.AddForce(4, 0, 0, ForceMode.Acceleration);
            //_animEnemy.back_by_attack(true);
        }
        /*else
        {
            _animEnemy.back_by_attack(false);
        }*/
    }
}
