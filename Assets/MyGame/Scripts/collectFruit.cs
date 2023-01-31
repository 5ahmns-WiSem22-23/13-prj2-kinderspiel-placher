using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class collectFruit : MonoBehaviour
{
    public RandomColor randomColor;

    public int counter;
    [SerializeField]
    private TMP_Text counterText;

    [SerializeField]
    private GameObject chewingBear;


    // Start is called before the first frame update
    void Start()
    {
        chewingBear.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = counter.ToString();
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "apple" && randomColor.selectedFruit.name == "apple-158419_1280 (1)")
        {
            Debug.Log("apple collected");
            counter++;
            chewingBear.SetActive(true);
            StartCoroutine(Waiting());
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3((float)-5.7, (float)-3.5, 0);
        }


        if (collision.name != "apple" && randomColor.selectedFruit.name == "apple-158419_1280 (1)")
        {
            counter--;
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }

        if (collision.name == "pineapple" && randomColor.selectedFruit.name == "pineapple-25251_1280 (1)")
        {
            Debug.Log("pineapple collected");
            counter++;
            chewingBear.SetActive(true);
            StartCoroutine(Waiting());
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3((float)2.7, (float)-3.5, 0);
        }

        if (collision.name != "pineapple" && randomColor.selectedFruit.name == "pineapple-25251_1280 (1)")
        {
            counter--;
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }
        if (collision.name == "kiwi" && randomColor.selectedFruit.name == "kiwi-161728_1280 (1)")
        {
            Debug.Log("kiwi collected");
            counter++;
            chewingBear.SetActive(true);
            StartCoroutine(Waiting());
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3((float)-2.2, (float)-3.5, 0);
        }

        if (collision.name != "kiwi" && randomColor.selectedFruit.name == "kiwi-161728_1280 (1)")
         {
             counter--;
             Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }
        if (collision.name == "raspberry" && randomColor.selectedFruit.name == "raspberry-2161523_1280 (1)")
        {
            Debug.Log("raspberry collected");
            counter++;
            chewingBear.SetActive(true);
            StartCoroutine(Waiting());
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3((float)6.5, (float)-3.5, 0);

        }

        
        if (collision.name != "raspberry" && randomColor.selectedFruit.name == "raspberry-2161523_1280 (1)")
        {
            counter--;
            Debug.Log(collision.name + counter);
            collision.transform.position = new Vector3(collision.gameObject.transform.position.x, (float)-3.5, 0);
        }

    }

    IEnumerator Waiting()
    {
        randomColor.selectedFruit.SetActive(false);
        yield return new WaitForSeconds((float)1.5);
        chewingBear.SetActive(false);
        randomColor.RandomFood();
    }

}
