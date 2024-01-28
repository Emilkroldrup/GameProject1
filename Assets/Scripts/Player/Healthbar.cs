using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider slider;
    public Gradient Farver;
    public Image fill;

    public void setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = Farver.Evaluate(1f);
    }

    public void sethealth(int health)
    {
        slider.value = health;
        fill.color = Farver.Evaluate(slider.normalizedValue);
    }
    
}
