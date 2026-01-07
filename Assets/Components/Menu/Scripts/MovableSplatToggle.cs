using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovableSplatToggle : MonoBehaviour
{
    public GameObject[] gsplats;
    void Start()
    {
        /*gsplats = GameObject.FindGameObjectsWithTag("gsplat");
        if (gsplats == null)
        {
            Debug.LogError("No gsplats found in the scene.");
        }*/
    }

    public void SetMovableGsplatsEnabled(int disabled)
    {
        foreach (GameObject gsplat in gsplats)
        {
            // disable xr interaction components
            var interactable = gsplat.GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
            if (interactable != null)
            {
                interactable.enabled = disabled == 0;
            }
        }
    }
}
