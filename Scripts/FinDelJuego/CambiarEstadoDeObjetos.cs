using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CambiarEstadoDeObjetos : MonoBehaviour
{
    public GameObject ObjetoParaActivarYDesactivar;
    public GameObject azul, rojo;
    GameManager numGan = new GameManager();
    private int eljuga;

    // Start is called before the first frame update
    void Start()
    {
        int ganaInt = PlayerPrefs.GetInt("ganaInt");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Principal");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }


        Debug.Log(ganaInt + " ganaInt");
        if (ganaInt == 0)
        {
            //mostramos el azul
            azul.SetActive(true);
            rojo.SetActive(false);
        }
        else if (ganaInt == 1)
        {
            // mostramos el rojo
            azul.SetActive(false);
            rojo.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
