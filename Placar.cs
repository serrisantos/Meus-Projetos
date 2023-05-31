using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placar : MonoBehaviour
{
    Rigidbody rb;
    float speed;

    public Text Pontos;
    public Text Cereja;
    public Text Vida;

    public Transform inicialPonto;

    private bool PowerUp;

    private AudioSource pegarItem;

    int pontuacao;
    int contarFruta;
    int vida;

    //lerp
    public Color Inimigocomeça;
    public Color Inimigotermina;

    // Start is called before the first frame update
    void Start()
    {
        pegarItem = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        speed = 5;

        pontuacao = 0;
        contarFruta = 0;
        vida = 3;
        PowerUp = false;

        Pontos.text = "" + pontuacao;
        Cereja.text = "x" + contarFruta;
        Vida.text = "Vida x" + vida;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        rb.velocity = move * speed;
        PowerUp = ControladorJogo.TimerUp(PowerUp);
    }
        private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Item")
        {
            pontuacao += 1;
            Pontos.text = "" + pontuacao;
            Destroy(other.gameObject);
            pegarItem.Play();
        }

        if (other.tag == "Cereja")
        {
            contarFruta += 1;
            Cereja.text = "x" + contarFruta;
            Destroy(other.gameObject);
        }
        //recebe dano
        if (other.tag == "Inimigo" && PowerUp == false)
        {
            vida -= 1;
            Vida.text = "Vida x" + vida;
        }
        //para de receber dano
        if (other.tag == "Inimigo" && PowerUp == true)
        {
            other.transform.position = inicialPonto.position;
            //Destroy(other.gameObject);
        }
        if (other.tag == "PowerUp")
        {
            PowerUp = true;
            PowerUp = ControladorJogo.TimerUp(true);
            Destroy(other.gameObject);
        }
    }

    private void UpJogador()
    {
        Inimigocomeça = Color.red;
        Inimigotermina = Color.white;

        GetComponent<Renderer>().material.color = 
        Color.Lerp(Inimigotermina, Inimigocomeça, Mathf.PingPong(Time.time, 1));
    }   
}
