using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public AudioClip itemSound;
    public AudioSource audioSource;

    public bool firstItem = false;

    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideBag);
    }

    public void InsideBag(GameObject go)
    {   
        if (firstItem == false)
        {
        audioSource.PlayOneShot(itemSound);
        go.SetActive(false);

        //ChangeText.changeTextPath();
        firstItem = true;
        }

        else
        {
        audioSource.PlayOneShot(itemSound);
        go.SetActive(false);
        }
    }
}
