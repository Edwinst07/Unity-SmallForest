using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recoleccion : MonoBehaviour
{
    private int counterSeed, counterLand, counterWater;
    private Rigidbody rb;
    private UIManager _uiManager;


    private void Start()
    {
        _uiManager = Component.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("seed"))
        {
            Destroy(other.gameObject);
            counterSeed = counterSeed + 1;
            _uiManager.UpdatePointSeed(counterSeed);
           
        }
        if (other.CompareTag("land"))
        {
            Destroy(other.gameObject);
            counterLand = counterLand + 1;
            _uiManager.UpdatePointLand(counterLand);
        }
        if (other.CompareTag("water"))
        {
            Destroy(other.gameObject);
            counterWater = counterWater + 1;
            _uiManager.UpdatePointWater(counterWater);
        }

    }

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        counterSeed = 0;
    }


}
