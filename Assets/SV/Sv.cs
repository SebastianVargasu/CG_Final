using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sv : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] ParticleSystem target;
    public void onPlay()
    {
        anim.enabled = true;
        target.Play();
        Invoke("Restart", 5.7f);
    }
    public void Restart()
    {
        Debug.Log("Se quitó el anim");
        anim.enabled = false;
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Redunar()
    {
        Time.timeScale = 1;
    }
}
