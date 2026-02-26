using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class EnemyHPController : MonoBehaviour
{
    public float damage = 1;
    private float currentHP;
    private Slider slider;
    public TMPro.TextMeshProUGUI winText;
    public GameObject playerSlider;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHP = 100;
        slider = gameObject.GetComponent<Slider>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if(currentHP > 0)
            {
                if(playerSlider.GetComponent<HPSliderController>().gameCondition == "Playing")
                {
                    currentHP -= damage;
                    slider.value = currentHP;
                }
            }
            
        }
        if(currentHP <= 0)
        {
            playerSlider.GetComponent<HPSliderController>().gameCondition = "Win";
            winText.gameObject.SetActive(true);
            //audioSource.Play();

        }
    }
}
