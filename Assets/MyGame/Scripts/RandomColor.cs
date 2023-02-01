using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public GameObject[] fruits;
    [SerializeField]
    private GameObject spawnPoint;

    private int index;

    public GameObject selectedFruit;

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
        fruits[index].SetActive(true);
        selectedFruit = fruits[index];
    }


}
