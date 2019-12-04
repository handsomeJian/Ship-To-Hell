using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampMove : MonoBehaviour
{

    public float height = 1.0f;
    public float speed = 1.0f;


    private float rad = 0.0f;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rad = Random.value * 2 * Mathf.PI;
    }

    // Update is called once per frame
    void Update()
    {
        rad += 0.01f * speed;
        transform.position = startPos + new Vector3(0.0f, Mathf.Sin(rad) * height, 0.0f);
    }
}
