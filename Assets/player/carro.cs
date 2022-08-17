using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carro : MonoBehaviour
{
    [SerializeField] WheelCollider direita;
    [SerializeField] WheelCollider esquerda;
    [SerializeField] WheelCollider tras;

    public float potenciaDeAceleracao = 300f;
    public float potenciaDeFreio = 500f;
    public float anguloMaximoParaVirar = 15f;
    private float aceleracaoAtual = 0f;
    private float freioAtual = 0f;
    private float anguloAtual = 0f;

    public GameObject ferramenta;
    public string Cena;
    
    private void Start()
    {
        Cena = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && ferramenta.activeInHierarchy == true)
        {
            ferramenta.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.R) && ferramenta.activeInHierarchy == false)
        {
            ferramenta.SetActive(true);
        }
        if(ferramenta.activeInHierarchy == true)
        {
            potenciaDeAceleracao = 400f;
        }
    }

    private void FixedUpdate(){
        aceleracaoAtual = potenciaDeAceleracao * Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
        {
            freioAtual = potenciaDeFreio;
        }
        else
        {
            freioAtual = 0f;
        }
        direita.motorTorque = aceleracaoAtual;
        esquerda.motorTorque = aceleracaoAtual;
        direita.brakeTorque = freioAtual;
        esquerda.brakeTorque = freioAtual;
        tras.brakeTorque = freioAtual;

        anguloAtual = anguloMaximoParaVirar * Input.GetAxis("Horizontal");
        direita.steerAngle = anguloAtual;
        esquerda.steerAngle = anguloAtual;

        if (Input.GetKey(KeyCode.Mouse1))
        {
            SceneManager.LoadScene(Cena);
        }
    }
    public void Morte()
    {
        
    }
}
