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

        playergold = PlayerPrefs.GetInt("PlayerGold", 0);

        Updatetext();
    }

    public void UpdateGoldOnEnemyDestroyed()
    {
        playergold += 10;
        Updatetext();

        PlayerPrefs.SetInt("PlayerGold", playergold);
        PlayerPrefs.Save();
    }

    public void Updatetext()
    {
        TEXT.text = playergold.ToString();
    }
}