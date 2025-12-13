using UnityEngine;

public class WaldoSpawner : MonoBehaviour
{
    public GameObject waldoPrefab;
    private GameObject[] spawnPoints;
    private int currentWaldoIndex = 0;
    void Start()
    {
        // Get all children of the WaldoSpawner to serve as possible spawn points
        spawnPoints = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPoints[i] = transform.GetChild(i).gameObject;
        }
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points found for WaldoSpawner.");
        }
    }

    // Update is called once per frame
    public void SpawnNewWaldo()
    {
        waldoPrefab.SetActive(false);
        // Move waldo to the next spawn point
        waldoPrefab.transform.position = spawnPoints[currentWaldoIndex].transform.position;
        waldoPrefab.SetActive(true);
        currentWaldoIndex = (currentWaldoIndex + 1) % spawnPoints.Length;
    }
}
