using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItems : MonoBehaviour
{
    [SerializeField] private float ItemPrice, ItemObtained, AddNowMoney, AddMoney, ReduceTimer, AddWorkers;

    [SerializeField] private GetMoney MoneyScript;

    public void BuyItem()
    {
        if(ItemObtained >= 1)
        {
            return;
        }

        if(MoneyScript.Money < ItemPrice)
        {            
            return;
        }

        MoneyScript.Money -= ItemPrice;

        MoneyScript.MoneyAdded += AddMoney;
        MoneyScript.Money += AddNowMoney;

        MoneyScript.TimeReset -= ReduceTimer;
        MoneyScript.Timer = MoneyScript.TimeReset;

        MoneyScript.Workers += AddWorkers;

        ItemObtained = 1;

        this.gameObject.SetActive(false);
    }
}
