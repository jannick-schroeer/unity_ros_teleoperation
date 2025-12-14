using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiObjectToggle : MonoBehaviour
{
    public TextMeshProUGUI currentObjectNameLabel;
    public GameObject[] gameObjects;
    private int currentIndex = 0;
    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            {
                gameObjects[i].SetActive(false);
            }
        }
        if (gameObjects.Length == 0)
        {
            Debug.LogError("No objects assigned to MultiObjectToggle.");
        } else
        {
            gameObjects[currentIndex].SetActive(true);
            currentObjectNameLabel.text = gameObjects[currentIndex].name;   
        }
    }

    public void SwapActiveObject()
    {
        gameObjects[currentIndex].SetActive(false);
        currentIndex = (currentIndex + 1) % gameObjects.Length;
        gameObjects[currentIndex].SetActive(true);
        currentObjectNameLabel.text = "Active: " + gameObjects[currentIndex].name;
    }
}
