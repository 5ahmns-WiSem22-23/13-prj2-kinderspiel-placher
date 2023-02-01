using System.Collections;
using UnityEngine;
using TMPro;

public class CollectFruit : MonoBehaviour
{
    public RandomColor randomColor;

    public int counter;
    [SerializeField]
    private TMP_Text counterText;

    [SerializeField]
    private GameObject chewingBear;

    void Start()
    {
        chewingBear.SetActive(false);
    }

    void Update()
    {
        if (counter >= 0)
        {
            counterText.text = counter.ToString();
        }
        else
        {
            counterText.text = "0";   
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "apple" && randomColor.selectedFruit.name == "apple-158419_1280 (1)")
        {
            counter++;
            chewingBear.SetActive(true);
            randomColor.selectedFruit.SetActive(false);
            StartCoroutine(Waiting());
            collision.transform.position = new Vector3((float)-5.7, (float)-3.5, 0);
        }


        if (collision.name != "apple" && randomColor.selectedFruit.name == "apple-158419_1280 (1)")
        {
            counter--;
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }

        if (collision.name == "pineapple" && randomColor.selectedFruit.name == "pineapple-25251_1280 (1)")
        {
            counter++;
            chewingBear.SetActive(true);
            randomColor.selectedFruit.SetActive(false);
            StartCoroutine(Waiting());
            collision.transform.position = new Vector3((float)2.7, (float)-3.5, 0);
        }

        if (collision.name != "pineapple" && randomColor.selectedFruit.name == "pineapple-25251_1280 (1)")
        {
            counter--;
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }
        if (collision.name == "kiwi" && randomColor.selectedFruit.name == "kiwi-161728_1280 (1)")
        {
            counter++;
            chewingBear.SetActive(true);
            randomColor.selectedFruit.SetActive(false);
            StartCoroutine(Waiting());
            collision.transform.position = new Vector3((float)-2.2, (float)-3.5, 0);
        }

        if (collision.name != "kiwi" && randomColor.selectedFruit.name == "kiwi-161728_1280 (1)")
         {
            counter--;
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }
        if (collision.name == "raspberry" && randomColor.selectedFruit.name == "raspberry-2161523_1280 (1)")
        {
            counter++;
            chewingBear.SetActive(true);
            randomColor.selectedFruit.SetActive(false);
            StartCoroutine(Waiting());
            collision.transform.position = new Vector3((float)6.5, (float)-3.5, 0);

        }
     
        if (collision.name != "raspberry" && randomColor.selectedFruit.name == "raspberry-2161523_1280 (1)")
        {
            counter--;
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }

    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds((float)1.5);
        chewingBear.SetActive(false);
        randomColor.RandomFood();
    }

}
