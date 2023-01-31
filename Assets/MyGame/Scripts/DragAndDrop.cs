using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour
{
   /* bool canMove;
    bool dragging;
    Collider2D collider;

    private bool appleCollected;
 
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;

        appleCollected = false;
    }

    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        if (Input.GetMouseButtonDown(0) || appleCollected)
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                canMoveApple = true;
            }
            else
            {
                canMoveApple = false;
            }
            if (canMove)
            {
                dragging = true;
            }


        }
        if (dragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMoveApple = false;
            dragging = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "apple")
        {
            appleCollected = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "apple")
        {
            appleCollected = false;
        }
    }
   */
}
