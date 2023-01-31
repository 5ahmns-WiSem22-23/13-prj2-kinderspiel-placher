using UnityEngine;

public class CursorSpoon : MonoBehaviour
{
    [SerializeField]
    private GameObject spoon;
    
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spoon.transform.position = mousePosition;
    }
}
