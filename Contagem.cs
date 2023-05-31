using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contagem : MonoBehaviour
{
    public Text texto;
    public static float time;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        time = 60;
        GameOver.SetActive(false);
        //Time.timescale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        texto.text = "" + Mathf.Round(time);

        if(time <= 10)
        {
            texto.color = Color.red;
        }
        if (time <= 0)
            gameOver();
        }
    public void gameOver()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
}