using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject menuScreen;
    public GameObject gameOverScreen;
    public GameObject distanceObject;
    public GameObject resumeScreen;
    public CarController CarController;
    public TextMeshProUGUI distanceText;
    public TextMeshProUGUI gameOverDistanceText;
    
    private string distance="";    
    void Start()
    {
       
    }
    void Update()
    {
        //if (CarController.isGameOver && CarController.distance != 0) {
        //    Time.timeScale = 0;
        //    gameOverDistanceText.text = "Distance:"+distance;
        //    gameOverScreen.SetActive(true);
        //    menuScreen.SetActive(false);
        //    distanceObject.SetActive(false);
        //    if (Input.GetKeyDown(KeyCode.Space)) {
        //        PlayerPrefs.DeleteAll();
        //        SceneManager.LoadScene(0);
        //        distanceObject.SetActive(true);
        //        menuScreen.SetActive(false);

        //    }
            

        
        //}
        distance = CarController.distance.ToString();
        distanceText.text = distance;
        if (menuScreen.activeSelf) {
            Time.timeScale = 0;
            distanceObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Space)) {
                CarController.isGameOver=false;
                menuScreen.SetActive(false);
                distanceObject.SetActive(true);
              
            }

        }
     

      
    }
}
