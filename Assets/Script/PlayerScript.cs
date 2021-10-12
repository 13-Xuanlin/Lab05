using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerScript : MonoBehaviour
{

    private int Score;
    public Text ScoreText;
    private int ScoreWin;
    public ParticleSystem sparkles;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Score = 0;
        ScoreText.GetComponent<Text>().text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        void CreateSparkles()
        {
            sparkles.Play();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {

            Score += 10;
            ScoreText.GetComponent<Text>().text = "Score: " + Score;
            Destroy(other.gameObject);
            sparkles.Play();
            CheckWinCondition();
                
            
        }
        if (other.gameObject.tag == "Water")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameLoseScene");

        }
    }
    private void CheckWinCondition()
    {
        if (Score == 60) 
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("GameWinScene");

        }
    }
}
