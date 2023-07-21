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
    public NavMeshAgent agente;
    public Animator animacion;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if(estarAlerta == true)
        {
            animacion.SetBool("walk",true);
            //transform.LookAt(jugador);
            Vector3 posjugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            //transform.LookAt(posjugador);
            //transform.position = Vector3.MoveTowards(transform.position,posjugador, velocidad * Time.deltaTime);
            agente.SetDestination(posjugador);
        }
        if(estarAlerta == false)
        {
            animacion.SetBool("walk",false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow; 
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
        Gizmos.color = Color.red;
    }
}
