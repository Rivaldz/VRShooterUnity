using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HitBall : MonoBehaviour
{
    public GameObject ball, cube, secondBall; 
    public float gazeTime = 2f;
    private float timer;
    private bool gazedAt,gazeCube,gazeBall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gazedAt && Input.GetButtonDown("Fire1"))
        {
            ball.SetActive(false);
            SoundManagerScript.PlaySound("click");

        }

        if (gazeCube && Input.GetButtonDown("Fire1"))
        {

            SoundManagerScript.PlaySound("destroy");
            cube.SetActive(false);
        }

        if (gazeBall && Input.GetButtonDown("Fire1")){
            secondBall.SetActive(false);
        }

    }

    public void PointerEnter()
    {
        gazedAt = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExit()
    {
        gazedAt = false;
        Debug.Log("PointerExit");
    }
     public void PointerEnterCube()
    {
        gazeCube = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExitCube()
    {
        gazeCube = false;
        Debug.Log("PointerExit");
    }

      public void PointerEnterBall2()
    {
        gazeBall = true;
        Debug.Log("PointerEnter");
    }

    public void PointerExitBall2()
    {
        gazeBall = false;
        Debug.Log("PointerExit");
    }
    public void PointerDown()
    {
        Debug.Log("PointerDown");
    }
}
