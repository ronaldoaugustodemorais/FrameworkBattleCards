using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject UILogin;

    public void Sair()
    {
        SceneManager.LoadScene("Login");
    }
}
