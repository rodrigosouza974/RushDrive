using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeaWidth;

    void Start()
    {
        startPos = transform.position;
        repeaWidth = GetComponent<BoxCollider>().size.z;
    }

    void Update()
    {
        if (transform.position.z < startPos.z - repeaWidth)
        {
            transform.position = startPos;
        }
    }
}
