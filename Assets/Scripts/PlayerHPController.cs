using System;
using UnityEngine;
using UnityEngine.UI;

public class HPSliderController : MonoBehaviour
{
    private Slider slider;
    public float damageRate = 1;
    private float currentHP;
    public String gameCondition; //Playing, Lose, Win
    public TMPro.TextMeshProUGUI loseText;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        currentHP = 100;
        gameCondition = "Playing";
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameCondition == "Playing")
        {
            currentHP -= (damageRate * Time.deltaTime);
            slider.value = currentHP;
        }
        
        if(currentHP <= 0)
        {
            gameCondition = "Lose";
        }

        if(gameCondition == "Lose")
        {
            loseText.gameObject.SetActive(true);
            //audioSource.Play();
        }
    }

}
