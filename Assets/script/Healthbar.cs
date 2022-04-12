using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public PStats playerHealth;
    public Image fillImage;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value <=slider.minValue)
        {
            fillImage.enabled=false;
        }
        if(slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled=true;
        }
        float fillValue= playerHealth.curHealth / playerHealth.health;
        slider.value = fillValue;
    }
}
