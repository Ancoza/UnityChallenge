using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    [SerializeField] private ToggleGroup selectLevel;

    private string nlevel;

    public void StartGame()
    {
        nlevel = selectLevel.GetFirstActiveToggle().name;
        switch (nlevel)
        {
            case "Cars":
                SceneManager.LoadScene("Prototype1");
                break;
            case "Plane":
                SceneManager.LoadScene("Challenge2");
                break;
            default:
                Debug.LogError("Improper command given!");
                break;
        }
    }
}
