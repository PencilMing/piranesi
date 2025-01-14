﻿using System;
using Researches;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverResearch : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Research _research;

    private void Awake()
    {
        _research = GetComponent<Research>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!_research.isVisible) return;
        HoverPanel.Instance.ShowText(_research.name +
                                     "\n\n" +
                                     _research.progress + "/" + _research.cost +
                                    "\n\n" +
                                     _research.description
        );
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HoverPanel.Instance.HideText();
    }
}