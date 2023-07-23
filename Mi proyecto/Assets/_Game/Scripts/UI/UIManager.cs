using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private Text puntuation;
    [SerializeField]
    private GameObject inventory;
    [SerializeField]
    private GameObject intro;
    [SerializeField]
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePuntuation(int point)
    {
        inventory.SetActive(true);
        puntuation.text = " 4 / " + point;
    }

    public void StartPlay()
    {
        intro.SetActive(false);
        
        player.SetActive(true);
    }

}
