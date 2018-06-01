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
}
