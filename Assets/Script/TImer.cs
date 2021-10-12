using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TImer : MonoBehaviour
{
    public Text timeText;
    public float levelTime;

    private float elapsedTime;
    private float levelElapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        levelElapsedTime = levelTime;
        timeText.text = "Time: " + levelElapsedTime.ToString("0.00");
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        {
            timeText.text = "Time:" + levelElapsedTime.ToString("0.00");
            levelElapsedTime -= Time.deltaTime;
            if (levelElapsedTime <= 0)
            {

                SceneManager.LoadScene("GameLoseScene");
            }
        }   }
}
