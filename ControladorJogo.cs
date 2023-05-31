using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJogo : MonoBehaviour
{
    public static float time;
    public static bool retorna;
    public Text TimeTela;

    private void Start()
    {
        time = 10;
    }
    void Update()
    {
        TimeTela.text = "" + Mathf.Round(time);
    }
    public static bool TimerUp(bool PowerUp)
    {
        retorna = PowerUp;
        if (PowerUp)
        {
            time -= Time.deltaTime;
            if(Mathf.Round(time)<=0)
            {
                time = 10;
                retorna = false;
            }
        }
        return retorna;
    }
}
