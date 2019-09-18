using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCollectible : MonoBehaviour
{
    public Material[] material;
    HUDScore HUDScore;
    Renderer rend;
    public PlayerSeen playerSeen;

    private void Start()
    {
        HUDScore = GameObject.Find("UI").GetComponent<HUDScore>();
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[0];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            HUDScore.score++;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Disguise"))
        {
            rend.sharedMaterial = material[1];
            other.gameObject.SetActive(false);
            playerSeen.detectable = false;
        }
    }

}

