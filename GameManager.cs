using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
      var playerController= FindObjectsOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnPlayer()
    {
        playerController.transform.position = playerController.respawnPoint;
    }
}
