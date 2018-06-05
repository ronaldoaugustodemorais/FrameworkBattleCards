﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Database : MonoBehaviour
{    
    private static bool created = false;

    List<Usuario> usuarios = new List<Usuario>();

    private void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
    }
    
    public void addUsuario(Usuario newUsuario)
    {                        
        usuarios.Add(newUsuario);

        PlayerPrefs.SetString("login: " + newUsuario.login, newUsuario.login);
        PlayerPrefs.SetString("password: "+ newUsuario.password, newUsuario.password);
        PlayerPrefs.SetString("nome: " + newUsuario.nome, newUsuario.nome);
        PlayerPrefs.SetString("email: " + newUsuario.email, newUsuario.email);
        PlayerPrefs.SetInt("cpf: " + newUsuario.cpf, (int)newUsuario.cpf);
        PlayerPrefs.SetInt("rg: " + newUsuario.rg, (int)newUsuario.rg);
        PlayerPrefs.SetInt("nascimento: " + newUsuario.nascimento, (int)newUsuario.nascimento);
        
        SceneManager.LoadScene("MainMenu");
    }

    public void pesquisarUsuario(string login)
    {        
        foreach (Usuario usuario in usuarios)
        {
            if(usuario.login == login)
            {
                EditarUsuario edit = new EditarUsuario();
                edit.loginInput.text = usuario.login;
                edit.passwordInput.text = usuario.password;
                edit.nomeInput.text = usuario.nome;
                edit.emailInput.text = usuario.email;
                edit.cpfInput.text = (usuario.cpf).ToString();
                edit.rgInput.text = (usuario.rg).ToString();
                edit.nascimentoInput.text = (usuario.nascimento).ToString();
            }        
        }        
    }

    public void editUsuario(Usuario newUsuario)
    {        
        if(PlayerPrefs.GetString("login: "+newUsuario.login) == newUsuario.login)
        {
            PlayerPrefs.SetString("login: " + newUsuario.login, newUsuario.login);
            PlayerPrefs.SetString("password: " + newUsuario.password, newUsuario.password);
            PlayerPrefs.SetString("nome: " + newUsuario.nome, newUsuario.nome);
            PlayerPrefs.SetString("email: " + newUsuario.email, newUsuario.email);
            PlayerPrefs.SetInt("cpf: " + newUsuario.cpf, (int)newUsuario.cpf);
            PlayerPrefs.SetInt("rg: " + newUsuario.rg, (int)newUsuario.rg);
            PlayerPrefs.SetInt("nascimento: " + newUsuario.nascimento, (int)newUsuario.nascimento);
        }
        
        else
        {
            print("Login nao encontrado");
        }

        SceneManager.LoadScene("MainMenu");
    }

    /*
    public void addBaralho(Usuario newUsuario)
    {
        usuarios.Add(newUsuario);

        PlayerPrefs.SetString("login: " + newUsuario.login, newUsuario.login);
        PlayerPrefs.SetString("password: " + newUsuario.password, newUsuario.password);
        PlayerPrefs.SetString("nome: " + newUsuario.nome, newUsuario.nome);
        PlayerPrefs.SetString("email: " + newUsuario.email, newUsuario.email);
        PlayerPrefs.SetInt("cpf: " + newUsuario.cpf, (int)newUsuario.cpf);
        PlayerPrefs.SetInt("rg: " + newUsuario.rg, (int)newUsuario.rg);
        PlayerPrefs.SetInt("nascimento: " + newUsuario.nascimento, (int)newUsuario.nascimento);

        SceneManager.LoadScene("MainMenu");
    }
    */
}
