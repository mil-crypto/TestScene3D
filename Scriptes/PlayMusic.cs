using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private Trigger _triggerLeft;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _triggerLeft.RandomStartLeftMusicEvent += Play;
    }

    private void OnDisable()
    {
        _triggerLeft.RandomStartLeftMusicEvent -= Play;
    }

    private void Play()
    {
        _audioSource.PlayOneShot(_audioClip);
    }
}
