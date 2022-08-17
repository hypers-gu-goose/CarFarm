using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    [SerializeField] GameObject CarroNovo;
    [SerializeField] GameObject CarroVelho;
    Transform posicaoSpawnCarro;

    void Start()
    {
        posicaoSpawnCarro = GameObject.FindWithTag("carroNovo").transform;
    }

    void CospeCarro()
    {
        Vector3 posicaoSpawnAtual = new Vector3(posicaoSpawnCarro.position.x, posicaoSpawnCarro.position.y, posicaoSpawnCarro.position.z);
        Instantiate(CarroNovo, posicaoSpawnAtual, Quaternion.identity);
        Destroy (CarroVelho);
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            CospeCarro();
        }
    }
}
