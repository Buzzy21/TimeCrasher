using System.Collections;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    private Vector2 screenBounds;
    public GameObject clockPrefab;
    public GameObject spikePrefab;
    public GameObject reversebombPrefab;
    public GameObject bombPrefab;
    public GameObject borderPrefab;
    private float clockRespawn = 0f;
    private float spikeRespawn = 0f;
    private float reversebombRespawn = 0f;
    private float bombRespawn = 0f;
    private float borderRespawn = 0f;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3 (Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spikeWave());
        StartCoroutine(bombWave());
        StartCoroutine(borderWave());
        StartCoroutine(clockWave());
    }
    private void spawnReverse()
    {
        GameObject b = Instantiate(reversebombPrefab) as GameObject;
        b.transform.position = new Vector2 (-screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnClock()
    {
        GameObject f = Instantiate(clockPrefab) as GameObject;
        f.transform.position = new Vector2(-screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnBomb() 
    {
        GameObject c = Instantiate(bombPrefab) as GameObject;
        c.transform.position = new Vector2 (-screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnBorder ()
    {
        GameObject d = Instantiate(borderPrefab) as GameObject;
        d.transform.position = new Vector2 (-screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnSpike()
    {
        GameObject a = Instantiate(spikePrefab) as GameObject;
        a.transform.position = new Vector2 (-screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
    IEnumerator spikeWave()
    {
        while (true)
        {
            spikeRespawn = Random.Range(0.35f, 0.75f);
            yield return new WaitForSeconds (spikeRespawn);
            spawnSpike();
        }
    }
    IEnumerator bombWave() 
    {
        while (true)
        {
            reversebombRespawn = Random.Range(0.6f, 0.75f);
            yield return new WaitForSeconds (reversebombRespawn);
            spawnReverse();
            bombRespawn = Random.Range(0.6f, 0.75f);
            yield return new WaitForSeconds (bombRespawn);
            spawnBomb();
        }
    }
    IEnumerator borderWave()
    {
        while (true)
        {
            borderRespawn = Random.Range(5f, 7.5f);
            yield return new WaitForSeconds (borderRespawn);
            spawnBorder(); 
        }
    }
    IEnumerator clockWave()
    {
        while (true)
        {
            clockRespawn = Random.Range(4f, 6f);
            yield return new WaitForSeconds(clockRespawn);
            spawnClock();
        }
    }
}
