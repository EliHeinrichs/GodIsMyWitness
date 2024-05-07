using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine . UI;

public class Dialogue : MonoBehaviour
{

    public string[] texts;
    public Text dialogue;

    void OnEnable()
    {
        //when this object is setactive display a random string from the array
        int randomIndex = Random.Range(0, texts.Length);
        dialogue . text = texts [ randomIndex ];

    }

    

}
