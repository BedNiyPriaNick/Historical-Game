using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GetMoney : MonoBehaviour
{
    public float Money = 0, MoneyAdded, Timer, Workers = 1, Pizza, PizzaAdded;

    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private Text MoneyText;
    [SerializeField] private Text WorkerText;
    [SerializeField] private Text PizzaC;

    private int StartTimer = 0;

    [HideInInspector] public float TimeReset;

    [SerializeField] private GameObject human, money;
    Animator humanAnim, moneyAnim;

    [SerializeField] private Energy energy;

    private void Start()
    {
        TimeReset = Timer;
        try
        {
            humanAnim = human.GetComponent<Animator>();
            moneyAnim = money.GetComponent<Animator>();
        }
        catch { }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
        {
            StopGame();
        }

        if(energy?.bar.value <= 0)
        {
            Die();
        }

        TimerText.text = Timer.ToString("0.0");
        PizzaC.text = Pizza.ToString();

        if (StartTimer >= 1)
        {
            Timer -= 1 * Time.deltaTime;
        }

        if (Timer < -0)
        {
            Money += MoneyAdded;
            Pizza += PizzaAdded;
            Timer = TimeReset;
            StartTimer = 0;
        }

        try
        {   
            MoneyText.text = "Money: " + Money.ToString() + "$";
            WorkerText.text = "Workers: " + Workers.ToString();
        }
        catch
        {
            
        }
    }

    public void StartBtnClicked()
    {
        humanAnim.SetTrigger("work");
        try
        {
            humanAnim.StopPlayback();
            moneyAnim.StopPlayback();
            humanAnim.SetTrigger("work");
            moneyAnim.SetTrigger("go");
        }      
        catch
        {

        }
        StartTimer = 1;
    }

    [SerializeField] private GameObject stop_panel, death_panel;

    void StopGame()
    {
        stop_panel.SetActive(true);
        Time.timeScale *= 0;
    }

    void Die()
    {
        death_panel.SetActive(true);
        Time.timeScale *= 0;
    }

    public void Resume()
    {
        stop_panel.SetActive(false);
        Time.timeScale = 1;
    }
}
