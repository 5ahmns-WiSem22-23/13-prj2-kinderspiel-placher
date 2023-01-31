using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public GameObject[] fruits;
    [SerializeField]
    private GameObject spawnPoint;

    private int index;

    public GameObject selectedFruit;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i].SetActive(false);
        }
        RandomFood();
    }

    public void RandomFood()
    {
        index = Random.Range(0, fruits.Length);
        Debug.Log(fruits[index].gameObject);
        fruits[index].SetActive(true);
        selectedFruit = fruits[index];
    }


}
