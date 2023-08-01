using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossStatusBar : MonoBehaviour
{
    public BossController currentHealth;
    public Image fillImage;

    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
            SceneManager.LoadScene("LoseMenu");

        }

        if (slider.value > slider.minValue && !(fillImage.enabled))
        {
            fillImage.enabled = true;
        }

        float fillValue = currentHealth.currentHealth / currentHealth.maxHealth;

        if (fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.white;
        }
        else if (fillValue > slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        slider.value = fillValue;
    }
}