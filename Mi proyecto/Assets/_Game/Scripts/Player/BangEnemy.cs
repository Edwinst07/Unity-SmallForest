using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangEnemy : MonoBehaviour
{
    [SerializeField]
    private int idBang;
    [SerializeField]
    private GameObject directionLeftFoot, directionLeftHand, directionRightHand;
    private Vector3 directionBang;
    [SerializeField]
    private float distRayLeftFoot, distRayLeftHand, distRayRightHand;
    [SerializeField]
    private bool impact;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bodyPart();
    }

    private void bodyPart()
    {

        switch (idBang)
        {
            case 1:
                footLeft();
                break;
            case 2:
                handLeft();
                break;
            case 3:
                handRight();
                break;

        }

    }

    private void footLeft()
    {
        directionBang = directionLeftFoot.transform.position - this.transform.position;
        Debug.DrawRay(this.transform.position, directionBang*distRayLeftFoot, Color.red);
        Ray ray = new Ray(this.transform.position, directionBang*distRayLeftFoot);
        RaycastHit hit;
        impact = Physics.Raycast(ray, out hit);

        if(impact && hit.collider.tag == "Enemy")
        {
            Rigidbody rbEnemy = hit.collider.GetComponent<Rigidbody>();
            if (rbEnemy != null) rbEnemy.AddForce(ray.direction * 100f);

            Enemy enemy = hit.collider.GetComponent<Enemy>();
            
            if(enemy != null)
            {
                enemy.damage();
                Debug.Log("Live enemy: "+ enemy.live);
            }
        }
    }

    private void handLeft()
    {
        directionBang = directionLeftHand.transform.position - this.transform.position;
        Debug.DrawRay(this.transform.position, directionBang * distRayLeftHand, Color.red);
        Ray ray = new Ray(this.transform.position, directionBang * distRayLeftHand);
        RaycastHit hit;
        impact = Physics.Raycast(ray, out hit);

        if(impact && hit.collider.tag == "Enemy")
        {
            Rigidbody rbEnemy = hit.collider.GetComponent<Rigidbody>();

            if (rbEnemy != null) rbEnemy.AddForce(ray.direction * 100f); 

            Enemy enemy = hit.collider.GetComponent<Enemy>();
            if(enemy != null)
            {
                enemy.damage();
                Debug.Log("Live enemy: " + enemy.live);
            }
        }

    }

    private void handRight()
    {
        directionBang = directionRightHand.transform.position - this.transform.position;
        Debug.DrawRay(this.transform.position, directionBang * distRayRightHand, Color.red);
        Ray ray = new Ray(this.transform.position, directionBang * distRayRightHand);
        RaycastHit hit;
        impact = Physics.Raycast(ray, out hit);

        if(impact && hit.collider.tag == "Enemy")
        {
            Rigidbody rbEnemy = hit.collider.GetComponent<Rigidbody>();
            if (rbEnemy != null) rbEnemy.AddForce(ray.direction * 100f);

            Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemy.damage();
                Debug.Log("Live enemy: " + enemy.live);
            }
        }

    }

}
