using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pooper : MonoBehaviour
{
    public GameObject poopPrefab;
    public float poopLevel = 0f; 
    public float poopIncreaseRate;
    public float poopThreshold = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float prevPoop = poopLevel;
        ChangePoopLevel(poopIncreaseRate * Time.deltaTime);
    }

    public void ChangePoopLevel(float value) {
        poopLevel += value;
        if (poopLevel > poopThreshold) {
            Debug.Log("POOP");
            poopLevel -= poopThreshold;
            CreatePoop(new Vector3(Random.Range(-8.0f, 8.0f), -3f, 0f));
        }
        poopLevel = Mathf.Clamp(poopLevel, 0f, 100f);
    }

    public void CreatePoop(Vector3 position)
    {
        if (poopPrefab != null)
        {
            GameObject spriteInstance = Instantiate(poopPrefab, position, Quaternion.identity);
            // You can also set any additional properties of the spriteInstance here, if needed.
        }
        else
        {
            Debug.LogError("Sprite Prefab is not assigned!");
        }
    }
}
