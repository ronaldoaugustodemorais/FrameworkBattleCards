using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class EditarUsuario : MonoBehaviour
{
    Authentication authentication = new Authentication();
    Database data = new Database();

    public GameObject UIEditarUsuario;

    public InputField loginInput, passwordInput, nomeInput, emailInput, cpfInput, rgInput, nascimentoInput;

    string login, password, nome, email;
    long cpf, rg, nascimento;

    void Start()
    {
        UIEditarUsuario.active = false;
    }

    /*
    public void PesquisarUsuario(string login)
    {     
        
        Usuario usuario = data.pesquisarUsuario(login);

        if (PlayerPrefs.GetString("login: " + login) == usuario.login)
        {            
            loginInput.text = PlayerPrefs.GetString("login: " + usuario.login);
            passwordInput.text = PlayerPrefs.GetString("password: " + usuario.password);
            nomeInput.text = PlayerPrefs.GetString("nome: " + usuario.nome);
            emailInput.text = PlayerPrefs.GetString("email: " + usuario.email);
            cpfInput.text = (PlayerPrefs.GetInt("cpf: " + usuario.cpf)).ToString() ;
            rgInput.text = (PlayerPrefs.GetInt("rg: " + usuario.rg)).ToString();
            nascimentoInput.text = (PlayerPrefs.GetInt("nascimento: " + usuario.nascimento)).ToString();
        }
        else
        {
            print("LOGIN NAO ENCONTRADO");
        }
        
    }
    */

    public void EdicaoOK()
    {
        login = loginInput.text;
        password = passwordInput.text;
        nome = nomeInput.text;
        email = emailInput.text;
        cpf = Int64.Parse(cpfInput.text);
        rg = Int64.Parse(rgInput.text);
        nascimento = Int64.Parse(nascimentoInput.text);

        bool authOk = authentication.edicaoInit(login, password, nome, email, cpf, rg, nascimento);

        if (authOk == true)
        {
            //inicia o jogo para o menu principal
            print("Edicao realizada com sucesso!");
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados para cadastro.
            //pode-se criar um aviso em um pop-up
        }
    }
}
