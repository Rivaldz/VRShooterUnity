using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitBall : MonoBehaviour
{
    public GameObject ball, ball2, ball3, ball4, ball5,canvas,cubeNext;
    public float gazeTime = 2f;
    public Text txtScore;
     private float timer;
    private bool gazeBall,gazeBall2,gazeBall3,gazeBall4,gazeBall5,buttonNext;
    private int scores = 0;
    private bool isMuted;
    // Use this for initialization
    void Start()
    {
        canvas.SetActive(false);
        cubeNext.SetActive(false);
        isMuted = false;

    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (gazeBall == true && Input.GetButtonDown("Fire1"))
        {

            scores++;
            SoundManagerScript.PlaySound("destroy");
            ball.SetActive(false);
            gazeBall = false;

        }

        if(gazeBall2 == true && Input.GetButtonDown("Fire1"))
        {

            scores++;
            SoundManagerScript.PlaySound("destroy");
            ball2.SetActive(false);
            gazeBall2 = false;
        }

        if (gazeBall3 == true && Input.GetButtonDown("Fire1")){

            scores++;
            SoundManagerScript.PlaySound("destroy");
            ball3.SetActive(false);
            gazeBall3 = false;
        }

        if (gazeBall4 == true && Input.GetButtonDown("Fire1")){

            scores++;
            SoundManagerScript.PlaySound("destroy");
            ball4.SetActive(false);
            gazeBall4 = false;

        }

        if (gazeBall5 == true && Input.GetButtonDown("Fire1")){

            scores++;
            SoundManagerScript.PlaySound("destroy");
            ball5.SetActive(false);
            gazeBall5 = false;
        }
        if(buttonNext == true && Input.GetButtonDown("Fire1")){
            Debug.Log("klik button next");
            if(sceneName == "Scene1"){
                SceneManager.LoadScene(0);
            }
            else if(sceneName == "Scene2"){
                SceneManager.LoadScene(2);
            }
        }

        if(scores == 5){
            canvas.SetActive(true);
            cubeNext.SetActive(true);
        }
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
     public void ButtonEnter()
    {
        buttonNext= true;
        Debug.Log("PointerEnter NextButton");
    }

    public void ButtonExit()
    {
        buttonNext= false;
        Debug.Log("PointerExit NextButton");
    }

    public void MutePressed()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
    }

    public void KeluarAplikasi()
    {
        Application.Quit();
    }
}
