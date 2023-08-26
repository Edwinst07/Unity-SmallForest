using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Live : MonoBehaviour
{
    
    public bool gameOver = false;
    public int live=500;
    public LiveBar healthPlayer;


    // Start is called before the first frame update
    void Start()
    {
        
        
        healthPlayer = Component.FindObjectOfType<LiveBar>();
        healthPlayer.startBarLive(live);
    }

    public void Damage()
    {
        live --;

        healthPlayer.liveValue(live);
        
        if (live < 1)
        {

            gameOver = true;
        }
    }

}
