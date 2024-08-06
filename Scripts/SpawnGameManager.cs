
using UnityEngine;

public class SpawnGameManager : MonoBehaviour
{
    public GameObject managerPrefab;
    void Start()
    {
        GameObject gameManager = Instantiate(managerPrefab) as GameObject;
    }
    
}
