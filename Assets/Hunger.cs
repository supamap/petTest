using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    public float hungerLevel = 100f; // Start with a full hunger level of 100
    public float hungerDecreaseRate = 1f; // Amount of hunger decreased per second
    public Text hungerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Decrease hunger level over time
        ChangeHungerLevel(-hungerDecreaseRate * Time.deltaTime);

        // Update the UI Text with the current hunger level
        hungerText.text = "Hunger: " + hungerLevel.ToString("0"); // "0" format will show only integer values
        // You can add more logic here based on the hunger level, like triggering different pet behaviors, etc.
    }

    public void ChangeHungerLevel(float value) {
        hungerLevel += value;
        hungerLevel = Mathf.Clamp(hungerLevel, 0f, 100f);
    }
}
