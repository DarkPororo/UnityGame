using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    GameObject player;
    GameObject manager;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);

        if(transform.position.y < -3.51f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.2296576f;
        float r2 = 0.4593153f;

        if(d < r1 + r2)
        {
            manager.GetComponent<GameManager>().DecreaseHp();
            Destroy(gameObject);
        }
    }
}
