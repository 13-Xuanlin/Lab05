using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerScript : MonoBehaviour
{
    private int Score;
    public Text ScoreText;

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
        }
    }
}
