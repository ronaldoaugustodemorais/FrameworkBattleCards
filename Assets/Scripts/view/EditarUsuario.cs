using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using SFB;

public class EditarUsuario : MonoBehaviour
{
    Authentication authentication = new Authentication();
    Database data = new Database();

    public GameObject UIEditarUsuario, popupErrorScreen;
    public RawImage imgPerfil;
    public InputField loginInput, passwordInput;
    // nomeInput, emailInput, cpfInput, rgInput, nascimentoInput;

    string login, password, img, nome, email, pathOK;
    long cpf, rg, nascimento;

    void Start()
    {
        UIEditarUsuario.active = false;
        popupErrorScreen.active = false;
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
        img = pathOK;
        /*
        nome = nomeInput.text;
        email = emailInput.text;
        cpf = Int64.Parse(cpfInput.text);
        rg = Int64.Parse(rgInput.text);
        nascimento = Int64.Parse(nascimentoInput.text);
        */
        bool authOk = authentication.edicaoInit(login, password, img);

        if (authOk == true)
        {
            //inicia o jogo para o menu principal
            print("Edicao realizada com sucesso!");
            UIEditarUsuario.active = false;
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
    

    /*
     * APENAS ABRIR O EXPLORER
    public void ShowExplorer(string itemPath)
    {

        itemPath = itemPath.Replace(@"/", @"\");   // explorer doesn't like front slashes
        System.Diagnostics.Process.Start("explorer.exe", "/select," + itemPath);
    }

    */

    public void closeEdicaoUsuario()
    {
        UIEditarUsuario.active = false;
    }


}
