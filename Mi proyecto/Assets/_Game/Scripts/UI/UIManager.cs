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
    private GameObject player, enemy1, enemy2;
    [SerializeField]
    private GameObject mission1, dialog1, dialog2;
    [SerializeField]
    private AudioClip _audioClip;

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
    
    public void StartExtra()
    {
        itemExtra.SetActive(true);
        itemIntro.SetActive(false);
        AudioSource.PlayClipAtPoint(_audioClip, Camera.main.transform.position);
    }

    public void StartControl()
    {
        itemControl.SetActive(true);
        itemIntro.SetActive(false);
        AudioSource.PlayClipAtPoint(_audioClip, Camera.main.transform.position);
    }

    public void ReturnButton() 
    {

        itemControl.SetActive(false);
        itemExtra.SetActive(false);
        itemIntro.SetActive(true);
        AudioSource.PlayClipAtPoint(_audioClip, Camera.main.transform.position);
    }

    public void StartPlay()
    {
        itemIntro.SetActive(false);
        mission1.SetActive(true);
        AudioSource.PlayClipAtPoint(_audioClip,Camera.main.transform.position);
    }

    public void StartLeftButtonReturn()
    {
        if (mission1.activeInHierarchy)
        {
            mission1.SetActive(false);
            itemIntro.SetActive(true);
        }
        else if(dialog1.activeInHierarchy)
        {
            dialog1.SetActive(false);
            mission1.SetActive(true);
        }
        else if (dialog2.activeInHierarchy)
        {
            dialog2.SetActive(false);
            dialog1.SetActive(true) ;
        }
        AudioSource.PlayClipAtPoint(_audioClip ,Camera.main.transform.position);
    }

    public void StartRightButtonNext()
    {
        if (mission1.activeInHierarchy)
        {
            mission1.SetActive(false);
            dialog1 .SetActive(true);
        }
        else if (dialog1.activeInHierarchy)
        {
            dialog1.SetActive(false);
            dialog2.SetActive(true);
        }
        else if (dialog2.activeInHierarchy)
        {
            dialog2.SetActive(false);
            player.SetActive(true);
            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }
        AudioSource.PlayClipAtPoint(_audioClip, Camera.main.transform .position);
    }

}
