using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public static TextMeshPro Info;

    public bool HasGrabbedFlashlight;

    private void Start()
    {
        Info = gameObject.GetComponent<TextMeshPro>();
        
        HasGrabbedFlashlight = false;

        StartCoroutine(changeTextSupplies());
    }

    public static void changeTextDefault()
    {
        Info.text = " ";
    }

    IEnumerator changeTextSupplies()
    {
        Info.text = "I need to get more supplies";

        yield return new WaitForSeconds(10);

        changeTextFlashlight();
    }    

    public void changeTextFlashlight()
    {
        if (HasGrabbedFlashlight == false)
        {
        Info.text = "Let me grab my <br>flashlight off my hip";
        }

    }

    public static void changeTextBackpack()
    {
        HasGrabbedFlashlight = true;

        Info.text = "Now I need me bag <br>off my back";
    }

    public static void changeTextBook()
    {
        Info.text = "I should put the book <br>in my bag";
    }

    IEnumerator changeTextPath()
    {
        Info.text = "Now I just need to <br>follow the path";

        yield return new WaitForSeconds(15);

        changeTextDefault();
    }


}
