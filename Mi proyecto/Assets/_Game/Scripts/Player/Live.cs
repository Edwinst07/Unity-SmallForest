using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live : MonoBehaviour
{
    private LiveBar _liveBar;
    public bool gameOver = false;
    //private UIManager _uiManager;
    //private const int liveMax = 100;
    //private const int liveMin = 0;
    public int counterLive;
    // Start is called before the first frame update
    void Start()
    {
        //_uiManager = Component.FindObjectOfType<UIManager>();
        _liveBar = Component.FindObjectOfType<LiveBar>();
        ///_liveBar.liveMax(liveMax);
        //_liveBar.liveMin(liveMin);
    }

    // Update is called once per frame
    void Update()
    {
        Damage();
    }

    private void Damage()
    {
        _liveBar.liveValue(counterLive);
        if (counterLive < 1)
        {

            gameOver = true;
        }
    }

}
