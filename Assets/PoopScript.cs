using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopScript : MonoBehaviour
{

    private void OnMouseDown()
    {
        // Destroy the clicked game object (instance of the prefab)
        Destroy(gameObject);
    }
    
}
