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
        startPosZ = 55f;      // Posi��o inicial (onde come�a o movimento)
        endPosZ = -10f;     // Posi��o final (onde termina o movimento)
        backgroundSize = GetComponent<BoxCollider>().size.z; // Pegando o tamanho do fundo
    }

    void Update()
    {

        // Se o fundo ultrapassar a posi��o final (-10), reposiciona para 50
        if (transform.position.z <= endPosZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, startPosZ);
        }
    }
}

