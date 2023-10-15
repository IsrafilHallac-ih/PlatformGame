using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   [SerializeField] private Rigidbody rb;
    [SerializeField] private float pushForce = 1000f;
    [SerializeField] private float movement;
    [SerializeField] private float speed = 5f;
    public Vector3 respawnPoint;
   [SerializeField] private GameManager gameManager;

        void Start()
    {
        rb = GetComponent<Rigidbody>();
        respawnPoint = this.transform.position;
        var gameManager = FindObjectsOfType<GameManager>();
    }

    
    void Update()
    {

        movement = Input.GetAxis("Horizontal"); 
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, pushForce * Time.fixedDeltaTime);
        rb.velocity = new Vector3(movement * speed, rb.velocity.y, rb.velocity.z);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Barier"))
        {
            gameManager.RespawnPlayer();
        }

        
    }
}
