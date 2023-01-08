using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private Transform pizzaPoint;
    [SerializeField] private GameObject pizza;

    void InstantiatePizza()
    {
        Instantiate(pizza, pizzaPoint.position, Quaternion.identity);
    }
}
