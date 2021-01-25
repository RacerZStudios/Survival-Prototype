using System.Collections;
using System.Collections.Generic;
using TMPro; 
using UnityEngine;

public class ZombieText_Controller : MonoBehaviour
{
    [SerializeField] public TMP_Text text;
    [SerializeField] private EnemyController eC;
    [SerializeField] private CoinController coinCol; 
    public int ZombiesAlive = 5;
    public bool colelctedCoin = false;

    private void Start()
    {
        if (text.text != ZombiesAlive.ToString())
        {
            text.text = "5";
        }
    }

    public void KilledZombie()
    {
        eC.isDead = true;
        text.GetComponentInChildren<TMP_Text>();
        text.text = ZombiesAlive.ToString();
    }

    public void NotKilledZombie()
    {
        eC.isDead = false;
        text.GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    {
        if(coinCol.collectedCoin == true)
        {
            colelctedCoin = true; 
            coinCol.CointCount.ToString(); 
            ZombiesAlive -= 1;
            return; 
        }

        if(coinCol.CointCount >= 4)
        {
            Debug.Log("Winner"); 
        }
    }
}
