using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NamedObjectToggle : MonoBehaviour
{
    public string objectName = "";
    private GameObject gameObject;
    void Start()
    {
        gameObject = GameObject.Find(objectName);
        if (gameObject == null)
        {
            Debug.LogError("No object found with the name: " + objectName);
        }
    }

    public void SetObjectEnabled(int disabled)
    {
        if (gameObject != null)
        {
            gameObject.SetActive(disabled == 0);
        }
    }
}
