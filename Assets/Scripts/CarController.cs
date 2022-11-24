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
        if (speed<29) {
            if (distance == 50) speed++;
            if (distance == 200) speed++;
            if (distance == 350) speed++;
            if (distance == 500) speed = speed + 2;
            if (distance == 1000) speed = speed + 2;
            if (distance == 3000) speed = speed + 2;
            if (distance == 5000) speed = speed + 2;
            if (distance == 10000) speed++;
            if (distance == 15000) speed++;
            if (distance == 20000) speed++;
        }
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);

        car.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z + speed * Time.deltaTime);
            
        car.transform.position += velocity * speed * Time.deltaTime*Time.timeScale;
     
        if (!isGameOver) {
            Time.timeScale = 1;      
        }
        else {
            Time.timeScale = 0;        
        }
        distance = (int)car.transform.position.z;
        Debug.Log(distance.ToString());
    }

    private void OnCollisionEnter(Collision collision) {
        //if (collision.gameObject.tag == "Barrier") {
        //    Debug.Log("Game over");
        //    Time.timeScale = 0;
        //    isGameOver = true;
            
        //}
        //if (collision.gameObject.tag=="Coin") {
        //    score += 5;
        //}
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "RoadEnd") {
            spawnManager.RoadSpawnEntered();

        }
    }


}
