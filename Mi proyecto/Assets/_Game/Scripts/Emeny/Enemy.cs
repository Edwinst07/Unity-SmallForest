using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
//using UnityEditor.Animations;

public class Enemy : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    public NavMeshAgent agent;
    public int live = 90;

    [SerializeField]
    private bool estarAlerta;
    [SerializeField]
    private List<Transform> points;
    private int currentDestination;
    [SerializeField]
    private float changeDestinationDistance;
    private AnimationEnemy _anim;
    private string state = "Patrolling";
    [SerializeField]
    private Slider healthBar;
    [SerializeField]
    private bool impact = false;
    //[SerializeField]
    //private GameObject rayLeft, rayRight;
    [SerializeField]
    private GameObject rayEnemy;
    [SerializeField]
    private float distance;
    [SerializeField]
    private GameObject vectorRay;


    void Start()
    {
        _anim = GetComponent<AnimationEnemy>();
    }

    // Update is called once per frame
    void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);
        switch (state)
        {
            case "Patrolling":
                patrol();
                break;
            case "Chasing":
                chase();
                break;
            default: 
                break;
        }
        Debug.Log("State: " + state);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow; 
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
        Gizmos.color = Color.red;
    }

    private void chase()
    {
        

        if (estarAlerta == true)
        {
            //animacion.SetBool("walk", true);
            _anim.walk(true);
            //transform.LookAt(jugador);
            Vector3 posjugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            //transform.LookAt(posjugador);
            //transform.position = Vector3.MoveTowards(transform.position,posjugador, velocidad * Time.deltaTime);
            agent.SetDestination(posjugador);
            attack();
        }
        if (estarAlerta == false)
        {

            state = "Patrolling";
        }
    }

    private void patrol()
    {
        agent.SetDestination(points[currentDestination].position);
        if(Vector3.Distance(agent.destination, transform.position) < changeDestinationDistance)
        {
            changeDestination();
        }

        if (estarAlerta == true)
        {

            state = "Chasing";
        }
    }

    private void changeDestination()
    {
        if(currentDestination < (points.Count - 1))
        {
            currentDestination += 1;
            _anim.walk(true);
        }
        else
        {
            currentDestination = 0;
        }
        
    }

    private void attack()
    {
        Vector3 direction = rayEnemy.transform.position - vectorRay.transform.position;
        Debug.DrawRay(rayEnemy.transform.position, direction * distance, color: Color.yellow);
        Ray ray = new Ray(rayEnemy.transform.position, direction * distance);
        RaycastHit hit;
        impact = Physics.Raycast(ray, out hit);

        if(impact && hit.collider.CompareTag("Player"))
        {
            _anim.attack(true);
            Debug.Log("El rayo tocó el player");
        }
        else
        {
            _anim.attack(false);
            state = "Patrolling";
        }
    }

    public void damage()
    {
        live -= 3;

        healthBar.value = live;

        if(live <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}


