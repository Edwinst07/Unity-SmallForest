using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityEditor.Animations;

public class Enemigo : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    bool estarAlerta;
    public Transform jugador;
    public float velocidad;
    public NavMeshAgent agent;
    public Animator animacion;
    [SerializeField]
    private List<Transform> points;
    private int currentDestination;
    [SerializeField]
    private float changeDestinationDistance;

    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        patrol();
        chase();
      

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow; 
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
        Gizmos.color = Color.red;
    }

    private void chase()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if (estarAlerta == true)
        {
            animacion.SetBool("walk", true);
            //transform.LookAt(jugador);
            Vector3 posjugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            //transform.LookAt(posjugador);
            //transform.position = Vector3.MoveTowards(transform.position,posjugador, velocidad * Time.deltaTime);
            agent.SetDestination(posjugador);
        }
        if (estarAlerta == false)
        {
            animacion.SetBool("walk", false);
        }
    }

    private void patrol()
    {
        agent.SetDestination(points[currentDestination].position);
        if(Vector3.Distance(agent.destination, transform.position) < changeDestinationDistance)
        {
            changeDestination();
        }
    }

    private void changeDestination()
    {
        if(currentDestination < points.Count - 1)
        {
            currentDestination += 1;
        }
        else
        {
            currentDestination = 0;
        }
    }

}


