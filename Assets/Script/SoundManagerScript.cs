using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip destroy,click;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        destroy = Resources.Load<AudioClip>("destroysound");
        click = Resources.Load<AudioClip>("");
        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip){
        switch (clip)
        {
            case "destroy":
                audioSrc.PlayOneShot(destroy);
                break;
            case "click":
                audioSrc.PlayOneShot(click);
                break;

            // default:
        }
    }
}
