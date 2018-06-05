using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cadastrar : MonoBehaviour
{
    Authentication authentication = new Authentication();

    public GameObject UICadastrar;

    public InputField loginInput, passwordInput, nomeInput, emailInput, cpfInput, rgInput, nascimentoInput;

    string login, password, nome, email;
    long cpf, rg, nascimento;

    void Start()
    {
        UICadastrar.active = false;        
    }
    
    public void CadastroOK()
    {        
        login = loginInput.text;
        password = passwordInput.text;
        nome = nomeInput.text;
        email = emailInput.text;
        cpf = Int64.Parse(cpfInput.text);
        rg = Int64.Parse(rgInput.text);
        nascimento = Int64.Parse(nascimentoInput.text);        

        bool authOk = authentication.cadastroInit(login, password,nome,email,cpf,rg,nascimento);

        if (authOk == true)
        {
            //inicia o jogo para o menu principal
            print("Cadastro realizado com sucesso!");            
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados para cadastro.
            //pode-se criar um aviso em um pop-up
        }
    }
}
