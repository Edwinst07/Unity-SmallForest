using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayWing : MonoBehaviour
{

   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger Stay with Player");
            Live live = other.GetComponent<Live>();
            if (live != null)
            {
                live.Damage();
                Debug.Log("Live player: " + live.live);
            }

            
        }
    }

}
