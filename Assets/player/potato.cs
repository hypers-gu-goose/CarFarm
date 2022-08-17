using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potato : MonoBehaviour
{
    [SerializeField] GameObject Batata;
    [SerializeField] GameObject mudaBatata;
    Transform posicaoBatata;

        void Start()
    {
        posicaoBatata = Batata.transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "chao")
        {

            Vector3 posicaoBroto = new Vector3(posicaoBatata.position.x, posicaoBatata.position.y, posicaoBatata.position.z);
            Instantiate(mudaBatata, posicaoBroto, Quaternion.identity);
        }
    }
}
