using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform saida;
    public bool entrada;

    // Start is called before the first frame update
    void Start()
    {
        entrada = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(!entrada)
        {
            if(other.tag == "Player")
            {
                other.transform.position = saida.position;
                entrada = true;
            }
        }
        else
        {
            entrada = false;
        }
    }
}

