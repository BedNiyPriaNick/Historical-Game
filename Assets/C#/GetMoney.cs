using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetMoney : MonoBehaviour
{
    public float Money = 0, MoneyAdded, Timer, Workers = 1;

    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private Text MoneyText;
    [SerializeField] private Text WorkerText;

    private int StartTimer = 0;

    [HideInInspector] public float TimeReset;

    [SerializeField] private GameObject human, money;
    Animator humanAnim, moneyAnim;

    private void Start()
    {
        TimeReset = Timer;
        humanAnim = human.GetComponent<Animator>();
        moneyAnim = money.GetComponent<Animator>();
    }

    private void Update()
    {
        MoneyText.text = "Money: " + Money.ToString() + "$";
        TimerText.text = Timer.ToString("0.0");
        WorkerText.text = "Workers: " + Workers.ToString();

        if(StartTimer >= 1)
        {
            Timer -= 1 * Time.deltaTime;
        }

        if(Timer < -0)
        {
            if(Workers >= 1)
            {
                MoneyAdded += Workers;
            }
            Money += MoneyAdded;
            Timer = TimeReset;
            StartTimer = 0;
        }
    }

    public void StartBtnClicked()
    {
        humanAnim.StopPlayback();
        moneyAnim.StopPlayback();
        StartTimer = 1;
        humanAnim.SetTrigger("work");
        moneyAnim.SetTrigger("go");
    }
}
