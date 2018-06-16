using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validacoes : MonoBehaviour
{
    public bool loginValidate(string login)
    {        
        if (login.Length <= 15 && login.Length > 0)
        {
            return true;
        }
        else
        {
            return false;
        }        
    }

    public bool loginAuth(string login)
    {
        if (PlayerPrefs.GetString("login: "+login) == (""+login))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool passwordValidate(string password)
    {
        if (password.Length <= 18 && password.Length > 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool passwordAuth(string password)
    {
        if (PlayerPrefs.GetString("password: " + password) == ("" + password))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
