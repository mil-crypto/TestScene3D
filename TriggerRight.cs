using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TriggerRight : MonoBehaviour
{
    public event Action RandomStartRightMusicEvent;

    private void OnTriggerEnter(Collider other)
    {
        var rand = Random.Range(0, 100);
        if (other.CompareTag("Player"))
        {
            if (rand <= 50)
            {
                RandomStartRightMusicEvent?.Invoke();
            }
        }
        Debug.Log(rand);
    }
}
