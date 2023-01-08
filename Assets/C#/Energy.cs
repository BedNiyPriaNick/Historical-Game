using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy : MonoBehaviour
{
    [SerializeField] private float speed;
    [HideInInspector] public Slider bar;
    [SerializeField] private GameObject slider;
    [SerializeField] private Animator[] gears;
    [SerializeField] private GetMoney pizzaMaker;

    private void Start()
    {
        bar = slider.GetComponent<Slider>();
    }

    private void Update()
    {
        bar.value -= Time.deltaTime / 16;
    }

    public void AddEnergy()
    {
        if (pizzaMaker.Pizza < 2)
        {
            return;
        }

        for(int i = 0; i < gears.Length; i++)
        {
            gears[i].SetTrigger("gear");
        }

        float energy = 0.4f;
        bar.value += energy;
        pizzaMaker.Pizza -= 2;

        if(bar.value > bar.maxValue)
        {
            bar.value = bar.maxValue;
        }
    }
}
