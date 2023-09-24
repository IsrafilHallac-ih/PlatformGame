using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private float respawnDelay = 2f;
    [SerializeField] private bool isGameEnding = false;
    // Start is called before the first frame update
    void Start()
    {
      var playerController= FindObjectsOfType<PlayerController>();
    }
    public void RespawnPlayer()
    {
        if (isGameEnding==false)
        {
            StartCoroutine("RespawnCoroutine");
            isGameEnding = true;
        }
    }

    public void RespawnPlayer()
    {
        if (isGameEnding==false)
        {
            StartCoroutine("RespawnCoroutine");
            isGameEnding = true;
        }
    }

    public IEnumerator RespawnCoroutine()
    {
        playerController.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        playerController.transform.position = playerController.respawnPoint;
        playerController.gameObject.SetActive(true);
        isGameEnding = false;

    }
   

    
}
