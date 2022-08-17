using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimento : MonoBehaviour
{
    Transform posicaoCarrinho;
    public float afastamento = 6f;

    void Start()
    {
        posicaoCarrinho = GameObject.FindWithTag("Player").transform;
    }
    void SeguirJogador()
    {
        Vector3 posicaoAlvo = new Vector3(posicaoCarrinho.position.x, transform.position.y, posicaoCarrinho.position.z - afastamento);
        transform.position = posicaoAlvo;
    }
    void Update()
    {
        SeguirJogador();
    }
}
