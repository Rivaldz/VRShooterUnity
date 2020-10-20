using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HitBall : MonoBehaviour
{
    public GameObject ball, ball2, ball3, ball4, ball5,canvas;
    public float gazeTime = 2f;
    public Text txtScore;
    private float timer;
    private bool gazeBall,gazeBall2,gazeBall3,gazeBall4,gazeBall5;
    private int scores = 0;

    // Use this for initialization
    void Start()
    {
        canvas.SetActive(false);
        // scoresString = GetComponent<TextScores>();

    }

    // Update is called once per frame
    void Update()
    {

        if (gazeBall && Input.GetButtonDown("Fire1"))
        {

            scores++;
            ball.SetActive(false);
            SoundManagerScript.PlaySound("destroy");

        }

        if(gazeBall2 && Input.GetButtonDown("Fire1"))
        {

            scores++;
            ball2.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }

        if (gazeBall3 && Input.GetButtonDown("Fire1")){

            scores++;
            ball3.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }

        if (gazeBall4 && Input.GetButtonDown("Fire1")){

            scores++;
            ball4.SetActive(false);
            SoundManagerScript.PlaySound("destroy");

        }

        if (gazeBall5 && Input.GetButtonDown("Fire1")){

            scores++;
            ball5.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }

        // if(scores == 5){
        //     canvas.SetActive(true);
        // }
        txtScore.text="Scores : " + scores.ToString();

    }

    public void Ball1Enter()
    {
        gazeBall = true;
        Debug.Log("PointerEnter");
    }

    public void Ball1Exit()
    {
        gazeBall = false;
        Debug.Log("PointerExit");
    }

     public void Ball2Enter()
    {
        gazeBall2 = true;
        Debug.Log("PointerEnter");
    }

    public void Ball2Exit()
    {
        gazeBall2 = false;
        Debug.Log("PointerExit");
    }

      public void Ball3Enter()
    {
        gazeBall3 = true;
        Debug.Log("PointerEnter");
    }

    public void Ball3Exit()
    {
        gazeBall3 = false;
        Debug.Log("PointerExit");
    }
  public void Ball4Enter()
    {
        gazeBall4 = true;
        Debug.Log("PointerEnter");
    }

    public void Ball4Exit()
    {
        gazeBall4 = false;
        Debug.Log("PointerExit");
    }
  public void Ball5Enter()
    {
        gazeBall5= true;
        Debug.Log("PointerEnter");
    }

    public void Ball5Exit()
    {
        gazeBall5 = false;
        Debug.Log("PointerExit");
    }

}
