using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


[ExecuteInEditMode()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerfield;
    public TextMeshProUGUI descr;
    public Image image;
    public LayoutElement layoutElement;

    public int Charwraplimit;

    public void SetText(string content, string header = "")
    {
        if (string.IsNullOrEmpty(header))
        {
            headerfield.gameObject.SetActive(false);
        }
        else
        {
            headerfield.gameObject.SetActive(true);
            headerfield.text = header;
        }
        descr.text = content;

        int headerLength = headerfield.text.Length;
        int contentLength = descr.text.Length;
        layoutElement.enabled = (headerLength > Charwraplimit || contentLength > Charwraplimit) ? true : false;

    }
}