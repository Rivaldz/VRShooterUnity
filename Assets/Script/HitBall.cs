using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HitBall : MonoBehaviour
{
    public GameObject ball, ball2, ball3, ball4, ball5; 
    public float gazeTime = 2f;
    private float timer;
    private bool gazeBall,gazeBall2,gazeBall3,gazeBall4,gazeBall5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gazeBall && Input.GetButtonDown("Fire1"))
        {
            ball.SetActive(false);
            SoundManagerScript.PlaySound("destroy");

        }

        if (gazeBall2 && Input.GetButtonDown("Fire1"))
        {

            ball2.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }

        if (gazeBall3 && Input.GetButtonDown("Fire1")){
            ball3.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }

        if (gazeBall4 && Input.GetButtonDown("Fire1")){
            ball4.SetActive(false);
            SoundManagerScript.PlaySound("destroy");

        }

        if (gazeBall5 && Input.GetButtonDown("Fire1")){
            ball5.SetActive(false);
            SoundManagerScript.PlaySound("destroy");
        }
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
