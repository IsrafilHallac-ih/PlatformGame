using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private GameManager gameManager;
    public int coinSkor;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            gameManager.AddScore(coinSkor);
            Destroy(this.gameObject);
        }
        
    }

}
