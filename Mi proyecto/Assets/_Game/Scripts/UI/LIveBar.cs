using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LIveBar : MonoBehaviour
{
    private Slider _slider;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        _slider = GetComponent<Slider>();
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
}
