using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour
{
    public int coins;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Coin")
        {
            Col.gameObject.SetActive(false);
        }
        if (Col.gameObject.tag == "SuperCoin")
        {
            SceneManager.LoadScene("End");
        }
    }
}
