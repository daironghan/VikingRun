using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static int coin;
    public static GameManager inst;
    public Text txtCoin;
    
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addCoin()
    {
        coin++;
        txtCoin.text = "Coins: " + coin;
    }
    
}
