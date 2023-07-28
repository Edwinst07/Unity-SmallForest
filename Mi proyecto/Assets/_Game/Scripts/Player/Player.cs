using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public int counterLive;
    public bool gameOver = false;
    //private UIManager _uiManager;
    private LIveBar _liveBar;
    private const int liveMax = 100;
    private const int liveMin = 0;

    // Start is called before the first frame update
    void Start()
    {
        //_uiManager = Component.FindObjectOfType<UIManager>();
        _liveBar = Component.FindObjectOfType<LIveBar>();
        _liveBar.liveMax(liveMax);
        _liveBar.liveMin(liveMin);
    }

    // Update is called once per frame
    void Update()
    {
        live();

    }

    private void live()
    {
        _liveBar.liveValue(counterLive);
        if(counterLive < 1)
        {
            
            gameOver = true;
        }
    }

}
