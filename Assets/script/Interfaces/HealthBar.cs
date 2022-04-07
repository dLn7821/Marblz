using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth()
    {
        slider.maxValue = Stats.ehealth;
        slider.value = Stats.ecurHealth;
    }
    public void SetHealth()
    {
        slider.value = Stats.ecurHealth;
    }
}
