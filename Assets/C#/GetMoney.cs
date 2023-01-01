using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMoney : MonoBehaviour
{
    [SerializeField] private float Money = 0, MoneyAdded = 400, Timer;
    [SerializeField] private Text MoneyText, TimerText;
    private int StartTimer = 0;
    private float TimeReset;

    private void Start()
    {
        TimeReset = Timer;
    }

    private void Update()
    {
        MoneyText.text = Money.ToString("C2");
        TimerText.text = Timer.ToString("0.0");

        if(StartTimer >= 1)
        {
            Timer -= 1 * Time.deltaTime;
        }

        if(Timer < -0)
        {
            Money += MoneyAdded;
            Timer = TimeReset;
            StartTimer = 0;
        }
    }

    public void StartBtnClicked()
    {
        StartTimer = 1;
    }
}
