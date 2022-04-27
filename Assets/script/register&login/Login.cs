using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;
public class Login : MonoBehaviour
{
    public TMP_InputField nameField, passwordField;
    public Button submitButton;
    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        UnityWebRequest request = UnityWebRequest.Post("https://mrblz.000webhostapp.com/login.php", form);
        request.timeout = 5;
        yield return request.SendWebRequest();
        if (request.downloadHandler.text[0] == '0')
        {
            DBManager.username = nameField.text;
            DBManager.score = int.Parse(request.downloadHandler.text.Split('\t')[1]);
            Debug.Log("Logged in as" + DBManager.username);
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User login failed. Error #" + request.downloadHandler.text);
        }
    }
    // public void verifyInputs()
    // {
    //   submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >=8);
    // }
}
