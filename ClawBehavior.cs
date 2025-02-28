using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ClawBehavior : MonoBehaviour
{
    public Vector2 newPosition;
    public Vector3 mousePosG;
    Rigidbody2D body;
    public float speed;
    Camera cam;
    public GameObject[] candyVariants;
    GameObject newObject;
    public int candyCount;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body = GetComponent<Rigidbody2D>();
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed * Time.fixedDeltaTime);
        body.MovePosition(newPosition);
        SpawnCandy();
    }

    void SpawnCandy() {
        if(Input.GetMouseButtonDown(0) == true) {
            int numVariants = candyVariants.Length;
            if(numVariants > 0) {
                int selection = Random.Range(0, numVariants);
                newObject = Instantiate(candyVariants[selection], new Vector3(0.0f, 3f, 0.0f), Quaternion.identity);
            }
            candyCount++;
        }
    }

    public int getCandyCount() {
        return candyCount;
    }

}
