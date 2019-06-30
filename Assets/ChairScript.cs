using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairScript : MonoBehaviour
{
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }

    void onTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
        }
    }

    //void onTriggerExit (Collider player)
    //{
     //   if (player.gameObject.tag == "Player")
     //   {
     //       uiObject.SetActive(false);
     //   }
   // }
}
