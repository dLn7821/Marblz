using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddStats : MonoBehaviour
{
    public static float damage;
    public static float hp;
    public static float df;
    public void AttributeModified(Attribute attribute)
    {
        if (string.Concat(attribute.type) == "Damage")
        {
            damage += attribute.value.ModifiedValue;
        }
        if (string.Concat(attribute.type) == "Health")
        {
           hp += attribute.value.ModifiedValue;
        }
        if (string.Concat(attribute.type) == "Defense")
        {
           df += attribute.value.ModifiedValue;
        }


    }
}
