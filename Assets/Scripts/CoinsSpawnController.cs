using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawnController : MonoBehaviour {
    
    public float lastSpawnY;
    public float lastSpawnZ;
    public float destroyLenght;


    public float coinInterval;
    public List<GameObject> obstacles;


    public void SpawnCoin() {

        if (Time.timeScale>0) {
            lastSpawnZ += coinInterval;
            GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
            var clone = Instantiate(obstacle, new Vector3(Random.Range(-1, 1), lastSpawnY, lastSpawnZ), obstacle.transform.rotation);
            Destroy(clone, destroyLenght);
        }
    }
}
