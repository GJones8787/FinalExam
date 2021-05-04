using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliderscript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Text Timer;

    private void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            Timer.text = v.ToString("0");
        });
    }
}
