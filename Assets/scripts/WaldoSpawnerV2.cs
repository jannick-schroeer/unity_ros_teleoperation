using UnityEngine;

public class WaldoSpawnerV2 : MonoBehaviour
{
    private GameObject[] waldos;
    private int currentWaldoIndex = 0;
    void Start()
    {
        // Get all children of the WaldoSpawner to serve as possible spawn points
        waldos = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            waldos[i] = transform.GetChild(i).gameObject;
            waldos[i].SetActive(false);
        }
        if (waldos.Length == 0)
        {
            Debug.LogError("No Waldos Found.");
        }
        waldos[currentWaldoIndex].SetActive(true);
    }

    // Update is called once per frame
    public void SpawnNewWaldo()
    {
        waldos[currentWaldoIndex].SetActive(false);
        currentWaldoIndex = (currentWaldoIndex + 1) % waldos.Length;
        waldos[currentWaldoIndex].SetActive(true);
    }
}
