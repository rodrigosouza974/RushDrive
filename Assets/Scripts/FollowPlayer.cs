using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 7, -8);
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // posi��o em que a camera ira ficar atr�s do carro
        transform.position = player.transform.position + offset;
    }
}
