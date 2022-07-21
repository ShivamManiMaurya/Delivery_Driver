using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float stearSpeed = 100f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float bumpSpeed = 5f;
    [SerializeField] float boostSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        float stearAmount = Input.GetAxis("Horizontal") * stearSpeed * Time.deltaTime;
        float movementAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, stearAmount);
        transform.Translate(0, movementAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = bumpSpeed;
        Debug.Log("Ah!...Bumped");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpeedUps"))
        {
            moveSpeed = boostSpeed;
            Debug.Log("Boosterrrr....");
        }
    }
}
