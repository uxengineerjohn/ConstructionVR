using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button playButton, pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        OnPlayButtonClicked();
    }

    private void OnEnable()
    {
        if(!playButton || !pauseButton)
        {
            Debug.LogError("Missing Button Refs on VideoController");
            return;
        }
        playButton.onClick.AddListener(OnPlayButtonClicked);
        pauseButton.onClick.AddListener(OnPauseButtonClicked);
    }

    private void OnDisable()
    {
        playButton.onClick.RemoveListener(OnPlayButtonClicked);
        pauseButton.onClick.RemoveListener(OnPauseButtonClicked);
    }

    void OnPlayButtonClicked()
    {
        videoPlayer.Play();
        playButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    void OnPauseButtonClicked()
    {
        videoPlayer.Pause();
        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }
}
