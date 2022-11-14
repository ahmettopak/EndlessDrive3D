using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public GameObject car;
    public float speed;
    public int score=0;
    public int distance=0;
    public float turnSpeed;
    public Vector3 velocity;
    public SpawnManager spawnManager;
    public UIManager uiManager;
    public bool isGameOver;

    private void Start() {
        isGameOver = uiManager.menuScreen.activeSelf;
    }

    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z+speed*Time.timeScale*Time.deltaTime);
        car.transform.position += velocity*turnSpeed*Time.deltaTime;
        if (!isGameOver) {
            Time.timeScale = 1;
            if (Random.Range(0, 20) == 15) {
                spawnManager.BarrierSpawnEntered();
                spawnManager.CoinSpawnEntered();
            }       
        }
        else {
            Time.timeScale = 0;        
        }
        distance = (int)car.transform.position.z;
        Debug.Log(distance.ToString());
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Barrier") {
            Debug.Log("Game over");
            Time.timeScale = 0;
            isGameOver = true;
            
        }
        if (collision.gameObject.tag=="Coin") {
            score += 5;
        }
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "RoadEnd") {
            spawnManager.RoadSpawnEntered();
            
        }
    }


}
