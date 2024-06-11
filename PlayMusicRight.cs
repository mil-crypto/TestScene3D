using UnityEngine;

public class PlayMusicRight : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip; 
    [SerializeField] private TriggerRight _triggerRight;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _triggerRight.RandomStartRightMusicEvent += PlayMusic;
    }

    private void OnDisable()
    {
        _triggerRight.RandomStartRightMusicEvent -= PlayMusic;
    }

    private void PlayMusic()
    {
        _audioSource.PlayOneShot(_audioClip);
    }
}
