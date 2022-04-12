using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TooltipItemTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static string content;
    public static string header;
    public void Update()
    {
        header=GetComponent<ItemObject>().description;
        content=GetComponent<Item>().Name;
    }

 public void OnPointerEnter(PointerEventData eventData)
 {
 TooltipSystem.Show(content, header);
 }
 public void OnPointerExit(PointerEventData eventData)
 {
     TooltipSystem.Hide();
 }
}