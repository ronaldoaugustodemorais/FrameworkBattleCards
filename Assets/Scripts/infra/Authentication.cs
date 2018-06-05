using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Authentication : MonoBehaviour
{
    Database data = new Database();    

    public bool loginInit(string login, string password)
    {
        Validacoes validacoes = new Validacoes();

        //implementar validacoes/login da Google e PlayerPrefs
        //caso o login seja inicializado de forma correta, este metodo ira retornar true, validando assim o usuario e senha fornecidos, caso contrario, ira retornar false,
        //informando que nao foi possivel conectar-se com o usuario fornecido.

        //agora validar os usuarios por meio da camada control (validacoes)              
        bool loginOk = validacoes.loginValidate(login);
        bool passwordOk = validacoes.passwordValidate(password);
        if(loginOk == true)
        {
            print("Usuario verificado com sucesso");
            if (passwordOk == true)
            {
                print("Senha verificada com sucesso");
            }
            else if (passwordOk == false)
            {
                print("Favor digitar uma senha valida:");
                print("Minimo 6 caracteres, maximo de 18 caracteres, letras e numeros, ao menos 2 numeros");
            }
        }
        else if (loginOk == false)
        {
            print("Favor digitar um login valido:");
            print("Nao vazio, maximo de 15 caracteres, somente letras");
        }
        
        return loginOk;
    }

    public bool cadastroInit(string login, string password, string nome, string email, long cpf, long rg, long nascimento)
    {
        Validacoes validacoes = new Validacoes();
        
        //implementar validacoes/login da Google e PlayerPrefs
        //caso o login seja inicializado de forma correta, este metodo ira retornar true, validando assim o usuario e senha fornecidos, caso contrario, ira retornar false,
        //informando que nao foi possivel conectar-se com o usuario fornecido.

        //agora validar os usuarios por meio da camada control (validacoes)              
        bool loginOk = validacoes.loginValidate(login);
        bool passwordOk = validacoes.passwordValidate(password);
        if (loginOk == true)
        {
            print("Usuario criado com sucesso");
            if (passwordOk == true)
            {
                print("Senha criada com sucesso");
                Usuario novoUsuario = new Usuario(login, password, nome, email, cpf, rg, nascimento);
                data.addUsuario(novoUsuario);
            }
            else if (passwordOk == false)
            {
                print("Favor digitar uma senha valida:");
                print("Minimo 6 caracteres, maximo de 18 caracteres, letras e numeros, ao menos 2 numeros");
            }
        }
        else if (loginOk == false)
        {
            print("Favor digitar um login valido:");
            print("Nao vazio, maximo de 15 caracteres, somente letras");
        }

        return loginOk;
    }

    public bool edicaoInit(string login, string password, string nome, string email, long cpf, long rg, long nascimento)
    {
        Validacoes validacoes = new Validacoes();

        //implementar validacoes/login da Google e PlayerPrefs
        //caso o login seja inicializado de forma correta, este metodo ira retornar true, validando assim o usuario e senha fornecidos, caso contrario, ira retornar false,
        //informando que nao foi possivel conectar-se com o usuario fornecido.

        //agora validar os usuarios por meio da camada control (validacoes)              
        bool loginOk = validacoes.loginValidate(login);
        bool passwordOk = validacoes.passwordValidate(password);
        if (loginOk == true)
        {
            print("Usuario editado com sucesso");
            if (passwordOk == true)
            {                
                Usuario novoUsuario = new Usuario(login, password, nome, email, cpf, rg, nascimento);
                data.editUsuario(novoUsuario);
            }
            else if (passwordOk == false)
            {
                print("Favor digitar uma senha valida:");
                print("Minimo 6 caracteres, maximo de 18 caracteres, letras e numeros, ao menos 2 numeros");
            }
        }
        else if (loginOk == false)
        {
            print("Favor digitar um login valido:");
            print("Nao vazio, maximo de 15 caracteres, somente letras");
        }

        return loginOk;
    }
}
