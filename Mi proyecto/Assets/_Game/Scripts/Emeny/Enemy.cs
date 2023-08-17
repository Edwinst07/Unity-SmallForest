using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityEditor.Animations;

public class Enemy : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    public Transform jugador;
    public float velocidad;
    public NavMeshAgent agent;
    //public Animator animacion;
    [SerializeField]
    private bool estarAlerta;
    [SerializeField]
    private List<Transform> points;
    private int currentDestination;
    [SerializeField]
    private float changeDestinationDistance;
    private AnimationEnemy _anim;
    private string state ="Patrolling";

    
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
        }
        if (estarAlerta == false)
        {
            //animacion.SetBool("walk", false);
            //_anim.walk(false);

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
            //_anim.walk(false);
        }
        
    }

}


