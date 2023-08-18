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
    [SerializeField] 
    private Transform vectorDirection;
    [SerializeField]
    private Transform vectorFoot;

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
            Rigidbody rbEnemy = hit.collider.GetComponent<Rigidbody>();

            Vector3 direction = vectorFoot.position - vectorDirection.position;
            if (rbEnemy != null) rbEnemy.AddForce(direction * 100f);

            Enemy enemy = hit.collider.GetComponent<Enemy>();
            
            if (enemy != null)
            {
                enemy.damage();
                Debug.Log("Live: " + enemy.live);
            }

        }
    }
}
