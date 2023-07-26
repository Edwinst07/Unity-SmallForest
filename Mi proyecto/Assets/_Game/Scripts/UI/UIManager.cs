using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private Text puntuationSeed, puntuationLand, puntuationWater;
    [SerializeField]
    private GameObject inventorySeed, inventoryLand, inventoryWater;
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

    public void UpdatePointSeed(int point)
    {
        inventorySeed.SetActive(true);
        puntuationSeed.text = " 4 / " + point;
    }

    public void UpdatePointLand(int point)
    {
        inventoryLand.SetActive(true);
        puntuationLand.text = " 4 / " + point;
    }

    public void UpdatePointWater(int point)
    {
        inventoryWater.SetActive(true);
        puntuationWater.text = " 1 / " + point;
    }

    public void StartPlay()
    {
        intro.SetActive(false);
        
        player.SetActive(true);
    }

}
