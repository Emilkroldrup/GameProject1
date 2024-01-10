using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    public int playergold = 0;
    private TMP_Text TEXT;
 

    void Start()
    {
        TEXT = GetComponent<TMP_Text>();
        playergold = PlayerPrefs.GetInt("gold", 0);
        Debug.Log("Initial playergold: " + playergold);
        Updatetext();
      
    }

    public void UpdateGoldOnEnemyDestroyed()
    {
        playergold += 10;
        PlayerPrefs.SetInt("gold", playergold);
        PlayerPrefs.Save();
        Updatetext();
        

    }

    public void Updatetext()
    {
        TEXT.text = playergold.ToString();
    }
}