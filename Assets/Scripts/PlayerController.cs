using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0f, verticalMovement);

        GetComponent<Rigidbody>().MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }

    void onTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pickup"))
        {
            score ++;
            UnityEngine.Debug.Log("Score: " + score);

            Destroy(other.gameObject);
        }
    }
}
