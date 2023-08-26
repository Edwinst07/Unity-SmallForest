using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Live livePlayer = Component.FindObjectOfType<Live>();

        if (other.gameObject.CompareTag("Player"))
        {
            if (livePlayer != null)
            {
                while(livePlayer.live <= 499)
                {
                    livePlayer.live++;
                    livePlayer.healthPlayer.liveValue(livePlayer.live);
                }
            }
        }

        
    }
}
