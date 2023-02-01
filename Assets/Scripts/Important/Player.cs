using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float tapForce = 500;
    private Rigidbody2D playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime);
        if (Input.GetMouseButtonDown(0))
        {
            playerRigidbody.AddForce(Vector2.up * tapForce);
        }
    }
}