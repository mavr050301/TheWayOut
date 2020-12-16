using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.SceneManagement;
public class Store : MonoBehaviour
{
    public void Start()
    {
            PurchaseManager.OnPurchaseConsumable += PurchaseManager_OnPurchaseConsumable;
    }
    private void PurchaseManager_OnPurchaseConsumable(PurchaseEventArgs args)
    {
        switch (args.purchasedProduct.definition.id)
        {
            case "coins_buy":
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") +100);
                SceneManager.LoadScene("Menu");
                break;
        }
    }
}
