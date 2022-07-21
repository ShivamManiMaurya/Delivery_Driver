using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1); 

    bool hasPackage;

    [SerializeField] float destroyTime = 1f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Package Picked-Up");
            hasPackage = true;

            spriteRenderer.color = hasPackageColor;

            Destroy(collision.gameObject, destroyTime);
            
        }
        else if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Package deliverd to the Customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
        else if (collision.CompareTag("Customer"))
        {
            Debug.Log("Package Already deliverd");
        }
        else
        {
            Debug.Log("Not our customer...something fishy");
        }

    }
}
