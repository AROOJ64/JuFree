using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [Header("Slider")]
    [SerializeField] private Slider healthSlider;
    [SerializeField] private Image HPSliderFill;
    [SerializeField] private Gradient _HPGradient;

    public void Start()
    {
        healthSlider.value = 100;
    }

    public void SetSlider(float amount)
    {
        //healthSlider.value = amount;
        amount = Mathf.Clamp(amount, 0f, 100f);
        Debug.Log(amount);
        //healthSlider.DOValue(amount, 0.6f);
        healthSlider.value = amount;
        //if(healthSlider.value <= 0f)
        //{
        //    HPSliderFill.color = Color.red;
        //}
       // HPSliderFill.color = _HPGradient.Evaluate(amount);
       // HPSliderFill.DOColor(_HPGradient.Evaluate(amount),0.6f);
    }
    public void SetSliderMax(float amount)
    {
        healthSlider.maxValue = amount;
        SetSlider(amount);
    }
}