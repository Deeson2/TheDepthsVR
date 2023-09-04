using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public AudioClip itemSound;
    public AudioSource audioSource;
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideBag);
    }

    public void InsideBag(GameObject go)
    {      
        audioSource.PlayOneShot(itemSound);
        go.SetActive(false);
    }
}
