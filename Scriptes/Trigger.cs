using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Trigger : MonoBehaviour
{
    public event Action RandomStartLeftMusicEvent;

    private void OnTriggerEnter(Collider other)
    {
        var rand = Random.Range(0, 100);
        if (other.CompareTag("Player"))
        {
            if (rand <= 50)
            {
                RandomStartLeftMusicEvent?.Invoke();
            }
        }
        Debug.Log(rand);
    }
}
