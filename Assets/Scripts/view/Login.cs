using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    Authentication authentication = new Authentication();

    public InputField loginInput, passwordInput;
    public GameObject UIMainMenu,UILogin,UICadastrar;

    string login, password;

    void Start()
    {
        UIMainMenu.active = false;
        UILogin.active = true;
        UICadastrar.active = false;
    }

	public void LoginCapture()
    {
        login = loginInput.text;
        password = passwordInput.text;
        bool authOk = authentication.loginInit(login,password);
        
        if(authOk == true)
        {
            //inicia o jogo para o menu principal
            UIMainMenu.active = true;
            UILogin.active = false;
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados de login.
            //pode-se criar um aviso em um pop-up
        }
    }
    public void CadastroLocal()
    {
        UIMainMenu.active = false;
        UILogin.active = false;
        UICadastrar.active = true;        
    }
}
