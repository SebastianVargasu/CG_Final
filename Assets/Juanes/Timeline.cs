using UnityEngine;
using UnityEngine.Playables;

public class StartTimeline : MonoBehaviour
{
    public void Play(PlayableDirector target)
    {
        target.Play();
    }
}