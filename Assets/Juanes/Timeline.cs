using UnityEngine;
using UnityEngine.Playables;

public class StartTimeline : MonoBehaviour
{
    public PlayableDirector director;

    public void PlayTimeline()
    {
        if (director != null)
        {
            director.Play();
        }
    }
    public void TogglePlayPause()
    {
        if (director != null)
        {
            if (director.state == PlayState.Playing)
            {
                director.Pause();
            }
            else if (director.state == PlayState.Paused)
            {
                director.Play();
            }
        }
    }
}