using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Usuario : IComparable<Usuario>
{
    public string login, password, nome, email;
    public long cpf, rg, nascimento;

    public Usuario(string newLogin, string newPassword, string newNome, string newEmail, long newCpf, long newRg, long newNascimento)
    {
        login = newLogin;
        password = newPassword;
        nome = newNome;
        email = newEmail;
        cpf = newCpf;
        rg = newRg;
        nascimento = newNascimento;
    }

    public int CompareTo(Usuario other)
    {
        if(other == null)
        {
            return 1;
        }

        return -1;        
    }
    
}
