using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChairScript : MonoBehaviour
{
    public GameObject uiObject;
    public KeyCode interactKey;
    public string computerGame;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }
    }

    void OnTriggerStay (Collider player)
    {
        if (Input.GetKeyDown(interactKey) && player.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(computerGame);
        }
    }

    void OnTriggerExit (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
        }
    }
}
