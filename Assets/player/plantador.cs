using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantador : MonoBehaviour
{
    [SerializeField] GameObject batata;
    Transform posicaoCano;

    void Start()
    {
        posicaoCano = GameObject.FindWithTag("cano").transform;
    }

    void CospeBatatas()
    {
        Vector3 posicaoSpawn = new Vector3(posicaoCano.position.x, posicaoCano.position.y, posicaoCano.position.z);
        Instantiate(batata, posicaoSpawn, Quaternion.identity);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            CospeBatatas();
        }
    }
}
