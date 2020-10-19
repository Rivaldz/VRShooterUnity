using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBall : MonoBehaviour
{
    public GameObject target;
    bool gvrStatus;
    float gvrTimer;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus && Input.GetButtonDown("Fire1"))
        {
           target.SetActive(false);
           gvrTimer += Time.deltaTime;
        }
        
    }
    public void GVRon(){
        gvrStatus = true;
    }
    public void GVRoff(){
        gvrStatus = false;
        gvrTimer = 0;
    }
}
