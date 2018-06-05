using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    Authentication authentication = new Authentication();
    Database data = new Database();

    public InputField loginInput, passwordInput;
    public GameObject UILogin,UICadastrar,UIEditarUsuario;

    string login, password;

    void Start()
    {        
        UILogin.active = true;
        //UICadastrar.active = false;
    }

	public void LoginCapture()
    {
        login = loginInput.text;
        password = passwordInput.text;
        bool authOk = authentication.loginInit(login,password);
        
        if(authOk == true)
        {
            //inicia o jogo para o menu principal
            SceneManager.LoadScene("MainMenu");            
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados de login.
            //pode-se criar um aviso em um pop-up
        }
    }

    public void CadastroLocal()
    {
        UICadastrar.active = true;
        UILogin.active = false;

    }

    public void EditarUsuario()
    {        
        data.pesquisarUsuario(loginInput.text);
        UIEditarUsuario.active = true;
        UILogin.active = false;
    }
}
