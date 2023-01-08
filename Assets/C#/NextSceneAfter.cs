using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneAfter : MonoBehaviour
{
    private void Start()
    {
        Invoke("NxtLvl", 7);
    }

    void NxtLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
