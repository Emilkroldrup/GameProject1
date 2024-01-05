using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{

    [SerializeField]
   public int playergold = 0;
   
    private TMP_Text TEXT;
    // Start is called before the first frame update
    void Start()
    {
        TEXT = GetComponent<TMP_Text>();
        TEXT.text += playergold;
    }

    // Update is called once per frame

    public void UpdateGoldOnEnemyDestroyed()
    {
        playergold += 10;
        Updatetext();
        
    }
    public void Updatetext()
    {
        TEXT.text = playergold.ToString();

    }
}
