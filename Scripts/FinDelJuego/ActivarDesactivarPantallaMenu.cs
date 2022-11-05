using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActivarDesactivarPantallaMenu : MonoBehaviour
{
    public GameObject ObjetoParaActivarYDesactivar;
    public Button elbo, btnvolver, jugar;

    private void Start()
    {
        jugar.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Principal");
        });
    }
}
