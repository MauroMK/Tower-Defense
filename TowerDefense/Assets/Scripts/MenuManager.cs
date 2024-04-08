using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class MenuManager : MonoBehaviour
{
    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] Transform menu;

    private bool isShowing = false;


    private void OnGUI()
    {
        currencyUI.text = LevelManager.instance.currency.ToString();
    }

    public void SetSelecter()
    {
        
    }

    public void ShopHandler()
    {
        if (isShowing)
        {
            menu.DOMoveX(-121, 0.5f);
            isShowing = false;
        }
        else
        {
            menu.DOMoveX(121, 0.5f);
            isShowing = true;
        }
        
    }
}
