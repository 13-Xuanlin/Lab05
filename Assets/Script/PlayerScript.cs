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

  

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        ScoreText.GetComponent<Text>().text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {

            Score += 10;
            ScoreText.GetComponent<Text>().text = "Score: " + Score;
            Destroy(other.gameObject);
            CheckWinCondition();
        }
        if (other.gameObject.tag == "Water")
        {

            SceneManager.LoadScene("GameLoseScene");
        }
    }
    private void CheckWinCondition()
    {
        if (Score == 20) 
        {
            SceneManager.LoadScene("GameWinScene");
        }
    }
}
