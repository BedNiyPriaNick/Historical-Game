using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreens : MonoBehaviour
{
    [SerializeField] private bool isLeft;
    GameObject CAMERA;

    private void Awake()
    {
        CAMERA = Camera.main.gameObject;
    }

    public void Clicked()
    {
        if (isLeft)
            CAMERA.transform.position += new Vector3(-17.7f, 0f, CAMERA.transform.position.z);
        else
            CAMERA.transform.position += new Vector3(17.7f, 0f, -10f);
    }
}
