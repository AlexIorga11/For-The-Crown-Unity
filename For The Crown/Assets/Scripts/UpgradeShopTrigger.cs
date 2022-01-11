using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShopTrigger : MonoBehaviour
{
    private UpgradeShop UIParent;

    private void Awake()
    {
        UIParent = GetComponentInParent<UpgradeShop>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            UIParent.inArea = true;
        }        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            UIParent.inArea = false;
            UIParent.UpgradeShopUI.SetActive(false);
            UIParent.UiOpen = false;
        }
    }
}
