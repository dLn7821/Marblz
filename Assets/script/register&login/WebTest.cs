using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class WebTest : MonoBehaviour
{
    IEnumerator Start()
    {
        WWWForm form = new WWWForm();
        UnityWebRequest request = UnityWebRequest.Post("https://micellar-boatswain.000webhostapp.com/webtest.php", form);
        yield return request;
            
    }

   
}
