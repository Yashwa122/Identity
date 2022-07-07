using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;

    public Bullet projectile;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            player.transform.position += Vector3.right * 0.4f;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position += Vector3.left * 0.4f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet clone = Instantiate(projectile, transform.position, transform.rotation);

            clone.timeoutDestructor = 5;
        }
    }
}
