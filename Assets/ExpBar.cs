using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider slider;

    

    public void SetMaxExp(int exp)
    {
        slider.maxValue = exp;
        slider.value = exp;
    }

    public void SetExp(int exp)
    {
        slider.value = exp;
        
    }





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
