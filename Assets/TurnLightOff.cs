using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class TurnLightOff : MonoBehaviour
{
    public GameObject lightSource;
    public bool shouldLightBeOn = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(LightOn);
        grabInteractable.selectExited.AddListener(LightOff);
        shouldLightBeOn = false;
        toggle();
    }

    public void LightOff(SelectExitEventArgs args)
    {
        shouldLightBeOn = false;
        toggle();
    }

    public void LightOn(SelectEnterEventArgs args)
    {
        shouldLightBeOn = true;
        toggle();
    }

    public void toggle()
    {
        if(shouldLightBeOn == false)
        {
            lightSource.SetActive(false);
        }

        if(shouldLightBeOn == true)
        {
            lightSource.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        toggle();
    }
}
