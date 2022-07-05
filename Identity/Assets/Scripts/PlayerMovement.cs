using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += Vector3.left;
        }
    }
}
