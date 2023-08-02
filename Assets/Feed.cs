using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
    // Reference to the VirtualPet script
    public Hunger hungerScript;

    // Amount of food to increase the hunger level
    public float foodAmount = 10f;

    // This method is called when the button is clicked
    public void OnFeedButtonClicked()
    {
        // Increase the hunger level by the specified food amount
        hungerScript.ChangeHungerLevel(foodAmount);
    }
}
