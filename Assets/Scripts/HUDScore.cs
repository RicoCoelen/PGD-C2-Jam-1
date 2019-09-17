using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScore : MonoBehaviour
{
    public int score;
    Text collectibleText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        collectibleText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        collectibleText.text = "Collectibles: " + score;
    }
}
