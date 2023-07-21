using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recoleccion : MonoBehaviour
{
    private int contador;
    private Rigidbody rb;
    public Text puntuacion;
    //public Text terminaste;
    private UIManager _uiManager;


    private void Start()
    {
        _uiManager = Component.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("items"))
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            _uiManager.UpdatePuntuation(contador);
            //actualizarmarcador();
            /*
            if (contador >= 4)
            {
                terminaste.gameObject.SetActive(true);
            }
            */
        }

    }
    /*
    private void actualizarmarcador()
    {
        puntuacion.text = "Puntuacion: " + contador;
    }
    */
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        //actualizarmarcador();
        //terminaste.gameObject.SetActive(false);
    }


}
