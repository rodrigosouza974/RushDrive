using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBackground : MonoBehaviour
{
    private float startPosZ; // Posi��o inicial do fundo
    private float endPosZ;   // Posi��o final do fundo
    private float backgroundSize; // Tamanho total do fundo

    void Start()
    {
        startPosZ = 50f;      // Posi��o inicial (onde come�a o movimento)
        endPosZ = -6.17f;     // Posi��o final (onde termina o movimento)
        backgroundSize = GetComponent<BoxCollider>().size.z; // Pegando o tamanho do fundo
    }

    void Update()
    {
        // Movimento cont�nuo do fundo de 50 at� -10.6
        transform.position += Vector3.back * Time.deltaTime * 10; // Ajuste a velocidade aqui

        // Se o fundo ultrapassar a posi��o final (-10.6), reposiciona para 50
        if (transform.position.z <= endPosZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPosZ);
        }
    }
}

