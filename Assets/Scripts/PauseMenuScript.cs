using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public KeyCode testingKey;
    //use same setup for counting the score
    public TextMeshProUGUI testingText;
    public bool isPaused = false;


    void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;


    }

    
    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            //Debug.Log("Down");
            testingText.text = "Down";
            
        }
        else if (Input.GetKey(testingKey))
        {
            //Debug.Log("Hold");
            testingText.text = "Hold";
        }
        else if (Input.GetKeyUp(testingKey))
        {
            //Debug.Log("up");
            testingText.text = "Up";
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();


        }
    }

    public void TogglePauseGame()
    {
        isPaused = !isPaused;

        //will open and close menu
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;

        }
        else
        {
            Time.timeScale = 1f;

        }
    }


    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
