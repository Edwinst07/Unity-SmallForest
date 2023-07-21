using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigogolpe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("el jugador a sido dañado");
        }
    }
}
