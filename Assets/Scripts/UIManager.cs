using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject menuScreen;
    public GameObject gameOverScreen;
    public CarController CarController;
    void Start()
    {
       
    }
    void Update()
    {
        if (CarController.isGameOver&&CarController.distance!=0) {
            gameOverScreen.SetActive(true);
            menuScreen.SetActive(false);
            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.Space)) {
                CarController.isGameOver = false;
                gameOverScreen.SetActive(false);
                menuScreen.SetActive(false);
                Time.timeScale = 1;

            }
        }
        if (menuScreen.activeSelf) {
            Time.timeScale = 0;
            
            if (Input.GetKeyDown(KeyCode.Space)) {
                CarController.isGameOver=false;
                menuScreen.SetActive(false);
              
            }

        }
        if (gameOverScreen.activeSelf) {
            Time.timeScale = 0;

            if (Input.GetKeyDown(KeyCode.Space)) {
                PlayerPrefs.DeleteAll();
                SceneManager.LoadScene(0);
                menuScreen.SetActive(false);

            }

        }
        else {
            Time.timeScale = 1;
        }
      
    }
}
