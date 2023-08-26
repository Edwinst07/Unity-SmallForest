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
    private GameObject itemIntro, itemExtra, itemControl;
    [SerializeField]
    private GameObject player;


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
        puntuationWater.text = " 4 / " + point;
    }

    public void StartPlay()
    {
        itemIntro.SetActive(false);
        
        player.SetActive(true);
    }
    
    public void StartExtra()
    {
        itemControl.SetActive(true);
        itemIntro.SetActive(false);
    }

    public void StartControl()
    {
        itemControl.SetActive(true);
        itemIntro.SetActive(false);
    }

    public void ReturnButton() 
    {

        itemControl.SetActive(false);
        itemExtra.SetActive(false);
        itemIntro.SetActive(true);
    
    }

}
