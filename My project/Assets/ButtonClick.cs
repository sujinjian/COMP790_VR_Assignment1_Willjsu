using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballprefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballprefab);
            ball.transform.localPosition = transform.position;

            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(500, 700));

        }
        
    }
}
