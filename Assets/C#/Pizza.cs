using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    [SerializeField] private GetMoney get;
    [SerializeField] private float speed;

    private void Start()
    {
        StartCoroutine(AddingPizza());
    }

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }  

    IEnumerator AddingPizza()
    {
        yield return new WaitForSeconds(1);
        get.Pizza += get.PizzaAdded;
        this.gameObject.SetActive(false);
    }
}
