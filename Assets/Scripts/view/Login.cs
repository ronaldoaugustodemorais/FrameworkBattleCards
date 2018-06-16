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
    public GameObject UILogin,UICadastrar,UIEditarUsuario, popupErrorScreen;

    string login, password;

    void Start()
    {        
        UILogin.active = true;
        popupErrorScreen.active = false;        
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
            popupErrorScreen.active = true;

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

    public void closePopupError()
    {
        loginInput.text = "";
        passwordInput.text = "";
        popupErrorScreen.active = false;
    }
}
