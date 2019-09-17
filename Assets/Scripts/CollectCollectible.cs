using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectible : MonoBehaviour
{
    HUDScore HUDScore;

    private void Start()
    {
        HUDScore = GameObject.Find("UI").GetComponent<HUDScore>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            HUDScore.score++;
            other.gameObject.SetActive(false);
        }
    }

}

