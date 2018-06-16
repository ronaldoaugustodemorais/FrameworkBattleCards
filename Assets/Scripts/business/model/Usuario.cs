using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Usuario : IComparable<Usuario>
{
    public string login, password, nome, email, img;
    public long cpf, rg, nascimento;

    public Usuario(string newLogin, string newPassword, string newImg)
    {
        login = newLogin;
        password = newPassword;
        img = newImg;        
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
