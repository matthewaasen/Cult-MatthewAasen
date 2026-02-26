using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject playerSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerSlider.GetComponent<HPSliderController>().gameCondition == "Win")
        {
            gameObject.SetActive(false);
        }
    }
}
