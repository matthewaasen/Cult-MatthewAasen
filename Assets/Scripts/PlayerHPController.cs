using UnityEngine;
using UnityEngine.UI;

public class HPSliderController : MonoBehaviour
{
    private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        slider.value = 45;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
