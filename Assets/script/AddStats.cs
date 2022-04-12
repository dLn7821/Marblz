using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStats : MonoBehaviour
{
    
    public static float hp;
  public static float damage;
  
    public void Update()
    {
            
        if(string.Concat(GetComponent<Attribute>().type)=="Damage")
        {
          Debug.Log("sebzés");
        damage += GetComponent<Attribute>().value.modifiedValue;
        }
        Debug.Log("hápé");
         if(string.Concat(GetComponent<Attribute>().type)=="Health")
        {
           hp += GetComponent<Attribute>().value.modifiedValue;
        }
    }
    
    
}
