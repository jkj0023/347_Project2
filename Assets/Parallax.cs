using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float scrollSpeed = 4f;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.down * scrollSpeed * Time.deltaTime);
        if (transform.position.y < -20.02347f)
        {
            transform.position = startPos;
        }
    }
}
