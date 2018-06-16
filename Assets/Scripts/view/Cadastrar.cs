using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SFB;

public class Cadastrar : MonoBehaviour
{
    Authentication authentication = new Authentication();

    public GameObject UICadastrar, popupErrorScreen;
    public RawImage imgPerfil;
    public InputField loginInput, passwordInput;
    // nomeInput, emailInput, cpfInput, rgInput, nascimentoInput;

    string login, password, nome, email, img, pathOK;
    long cpf, rg, nascimento;

    void Start()
    {
        UICadastrar.active = false;
        popupErrorScreen.active = false;
    }
    
    public void CadastroOK()
    {        
        login = loginInput.text;
        password = passwordInput.text;
        img = pathOK;
        /*
        nome = nomeInput.text;
        email = emailInput.text;
        cpf = Int64.Parse(cpfInput.text);
        rg = Int64.Parse(rgInput.text);
        nascimento = Int64.Parse(nascimentoInput.text); 
        */

        bool authOk = authentication.cadastroInit(login, password,img);

        if (authOk == true)
        {
            //inicia o jogo para o menu principal
            print("Cadastro realizado com sucesso!");
            UICadastrar.active = false;
        }
        else if (authOk == false)
        {
            //solicita que seja verificado os dados para cadastro.
            popupErrorScreen.active = true;
        }
    }

    public void openImage()
    {
        pathOK = "";
        string[] filePath = StandaloneFileBrowser.OpenFilePanel("Open File", "", "", false);

        for (int i = 0; i < filePath.Length; i++)
        {
            pathOK += "" + filePath[i];
        }

        if (filePath.Length > 0)
        {
            StartCoroutine(OutputRoutine(new System.Uri(filePath[0]).AbsoluteUri));
        }
        
    }

    public void closeCadastrar()
    {
        UICadastrar.active = false;
    }

    public void closePopupError()
    {     
        popupErrorScreen.active = false;
    }

    private IEnumerator OutputRoutine(string url)
    {
        Debug.Log("URL: " + url);
        var loader = new WWW(url);
        yield return loader;
        imgPerfil.texture = loader.texture;
    }

}
