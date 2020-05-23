using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject fireGenerator;
    GameObject hpGauge;
    GameObject gameoverScreen;
    public float hp = 1f;

    // Start is called before the first frame update
    void Start()
    {
        this.fireGenerator = GameObject.Find("FireGenerator");
        this.hpGauge = GameObject.Find("Hpbar");
        this.gameoverScreen = GameObject.Find("GameOver");
        gameoverScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(hp<= 0.2f)
        {
            GameOver();
        }
    }

    public void DecreaseHp()
    {
        hp -= 0.2f;
        this.hpGauge.GetComponent<Image>().fillAmount = hp;
    }
    public void GameOver()
    {
        fireGenerator.SetActive(false);
        gameoverScreen.SetActive(true);
    }
}
