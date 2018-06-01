using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cadastrar : MonoBehaviour
{
    Authentication authentication = new Authentication();

    public GameObject UICadastrar,UIMainMenu;

    public InputField loginInput, passwordInput;

    string login, password;

    void Start()
    {
        UICadastrar.active = false;        
    }
    
    public void CadastroOK()
    {        
        login = loginInput.text;
        password = passwordInput.text;
        bool authOk = authentication.cadastroInit(login, password);

        if (authOk == true)
        {
            //inicia o jogo para o menu principal
            print("Cadastro realizado com sucesso!");

            UICadastrar.active = false;
            UIMainMenu.active = true;
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados para cadastro.
            //pode-se criar um aviso em um pop-up
        }
    }
}
