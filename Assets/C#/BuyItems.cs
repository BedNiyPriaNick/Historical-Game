using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuyItems : MonoBehaviour
{
    [SerializeField] private float ItemPrice, ItemObtained, AddNowMoney, AddMoney, ReduceTimer, AddWorkers, Pizza;

    [SerializeField] private GetMoney MoneyScript;

    [SerializeField] private bool nextLevelLoad;

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
        MoneyScript.Pizza -= Pizza;

        if (nextLevelLoad)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        MoneyScript.MoneyAdded += AddMoney;
        MoneyScript.Money += AddNowMoney;

        MoneyScript.TimeReset -= ReduceTimer;
        MoneyScript.Timer = MoneyScript.TimeReset;

        MoneyScript.Workers += AddWorkers;

        ItemObtained = 1;

        this.gameObject.SetActive(false);
    }
}
