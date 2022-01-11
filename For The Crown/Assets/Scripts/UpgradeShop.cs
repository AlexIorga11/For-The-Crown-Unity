using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShop : MonoBehaviour
{
    public bool inArea = false;
    public bool UiOpen = false;
    public GameObject UpgradeShopUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inArea == true)
        {
            if (UiOpen)
            {
                UpgradeShopUI.SetActive(false);
                UiOpen = false;
            }
            else
            { 
                UpgradeShopUI.SetActive(true);
                UiOpen = true;
            }
        }
    }
}
