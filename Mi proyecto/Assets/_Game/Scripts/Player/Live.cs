using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Live : MonoBehaviour
{
    
    public bool gameOver = false;
    public int live=500;
    private LiveBar healthPlayer;
    [SerializeField]
    private Slider _liveBar;

    // Start is called before the first frame update
    void Start()
    {
        
        //live = healthMax;
        healthPlayer = Component.FindObjectOfType<LiveBar>();
        healthPlayer.startBarLive(live);
    }

    public void Damage()
    {
        live --;

        healthPlayer.liveValue(live);
        _liveBar.value = live;
        if (live < 1)
        {

            gameOver = true;
        }
    }

}
