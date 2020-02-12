﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour
{
    public static DialogueUI inst;
    public GameObject dialogueName, dialogueSentence, leftPortrait, rightPortrait;

    private Text nameText, sentenceText;
    private Image leftPortraitImage, rightPortraitImage;

    private bool isActive = true;

    void Awake()
    {
        inst = this;
    }

    void Start()
    {
        OffDialogue();

        nameText = dialogueName.GetComponent<Text>();
        sentenceText = dialogueSentence.GetComponentInChildren<Text>();

        leftPortraitImage = leftPortrait.GetComponent<Image>();
        rightPortraitImage = rightPortrait.GetComponent<Image>();
    }


    /// <summary>
    /// dialogue UI ON/OFF
    /// </summary>
//    public void OnOffDialogue()
//    {
//        isActive = !isActive;
//        dialogueName.SetActive(isActive);
//        dialogueSentence.SetActive(isActive);
//    }

    public void OnDialogue()
    {
        if (!isActive)
        {
            isActive = true;

            dialogueName.SetActive(isActive);
            dialogueSentence.SetActive(isActive);
        }
    }

    public void OffDialogue()
    {
        if (isActive)
        {
            isActive = false;

            dialogueName.SetActive(isActive);
            dialogueSentence.SetActive(isActive);

            leftPortrait.SetActive(isActive);
            rightPortrait.SetActive(isActive);
        }
    }

    /// <summary>
    /// change dialogue UI name, text
    /// </summary>
    public void ChangeDialogueText(string name, string sentence)
    {
        nameText.text = name;
        sentenceText.text = sentence;
    }
}
