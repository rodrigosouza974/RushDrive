using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBackground : MonoBehaviour
{
    private float startPosZ; // Posição inicial do fundo
    private float endPosZ;   // Posição final do fundo
    private float backgroundSize; // Tamanho total do fundo

    void Start()
    {
        startPosZ = 50f;      // Posição inicial (onde começa o movimento)
        endPosZ = -6.17f;     // Posição final (onde termina o movimento)
        backgroundSize = GetComponent<BoxCollider>().size.z; // Pegando o tamanho do fundo
    }

    void Update()
    {

        // Se o fundo ultrapassar a posição final (-10.6), reposiciona para 50
        if (transform.position.z <= endPosZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPosZ);
        }
    }
}

