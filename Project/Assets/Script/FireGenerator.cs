using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGenerator : MonoBehaviour
{
    public GameObject firePrefabs;
    float span = 0.2f;
    float delta = 0;
    bool isStart = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
            isStart = true;
        if (isStart)
        {
            if(this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(firePrefabs) as GameObject;
                int px = Random.Range(-9, 9);
                go.transform.position = new Vector3(px, 4.59f, 0);
            }
        }
    }
}
