using NUnit.Framework.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEngine;

public class CameraTargetDetect : MonoBehaviour
{
    //a list of the game objects that the player is currently searching for
    public List<GameObject> currentTargets;
    GameManager gameManager;

    //switches to true if the players cursor is on a currently valid photo target
    bool onTarget = false;
    public List<Collider2D> currentCollision;

    void OnMouseDown()
    {
        Debug.Log("click!");

        //checks if the player has clicked on a currently availible target and removes it from the currentTargets list if they have, then updates the game state if the list is empty
        if (onTarget)
        {
            foreach (Collider2D currentTarget in currentCollision)
            {
                if(currentTargets.Contains(currentTarget.gameObject))
                {
                    currentTargets.Remove(currentTarget.gameObject);
                }
                
            }
            
            if (currentTargets.Count == 0)
            {
                gameManager.UpdateGameState((GameState)((int)gameManager.State + 1));
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Target") && currentTargets.Contains(collision.gameObject))
        {
            currentCollision.Add(collision);
            onTarget = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (onTarget)
        {
            if (currentCollision.Contains(collision))
            {
                currentCollision.Remove(collision);
            }
            onTarget = false;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        //This line is useful for testing
        currentTargets = GameObject.FindGameObjectsWithTag("Target").ToList<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        if (currentTargets == null)
        {
            currentTargets = new List<GameObject>();
        }
        Cursor.lockState = CursorLockMode.Locked;
    }
}
