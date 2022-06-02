using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModePlayer : MonoBehaviour
{
    public static ModePlayer sharedInstance;
    public Camera Cam1;
    public Camera HoodCam1;

    public Camera Cam2;

    public GameObject player2;
    
    [SerializeField] private ToggleGroup selectPlayers;

    private string nPlayers;
    public Canvas CarsMenu;

    public bool isPlaying;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }

    public void StartGame()
    {
        nPlayers = selectPlayers.GetFirstActiveToggle().name;
        if (nPlayers == "Two")
        {
            TwoPlayers();
            
        }
        isPlaying = true;
        CarsMenu.enabled = false;
    }
    void TwoPlayers()
    {
        player2.SetActive(true);
        Cam2.gameObject.SetActive(true);
        //Cam2.enabled = true;
        //playerCam1.rect.Set(0,0,0.5f,0);
        Cam1.rect = new Rect(0,0,0.5f,1);
        HoodCam1.rect = new Rect(0,0,0.5f,1);
    }
}
