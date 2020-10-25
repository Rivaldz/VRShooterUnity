using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlikingText : MonoBehaviour
{
    // Start is called before the first frame update
    // public Text txt;

    Text text;  
    void Start()
    {
        text = GetComponent<Text>();
        StartBlinking();
        
    }

    IEnumerator Blink()
    {
        while(true)
        {
            text.text = "YOU WINNER !!!";
            yield return new WaitForSeconds(1f);
            text.text = "";
            yield return new WaitForSeconds(0.70f);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void StartBlinking()
    {
        // StopCorountine("Blink");
        StartCoroutine("Blink");
    }

}
