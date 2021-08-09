using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class FuelScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fuelText;
    public int secondsLeft = 30;
    public bool takingAway = false;

    void Start()
    {
        fuelText.GetComponent<Text>().text = "00:" + secondsLeft;
    }

    private void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if (secondsLeft < 10)
        {
            fuelText.GetComponent<Text>().text = "00:0" + secondsLeft;
        }
        else
        {
            fuelText.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }
}
