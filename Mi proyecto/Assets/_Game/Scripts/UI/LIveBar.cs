using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveBar : MonoBehaviour
{
    private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void liveMin(int liveMin)
    {
        _slider.minValue = liveMin;
    }

    public void liveMax(int liveMax) {

        _slider.maxValue = liveMax;
    }

    public void liveValue(int liveValue) { 
    
        _slider.value = liveValue;
    }

    public void startBarLive(int healthValue)
    {
        liveMax(healthValue);
        liveValue(healthValue);
    }
}
