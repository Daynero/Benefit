using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenView : MonoBehaviour
{
    [SerializeField] private PanelView firstPanel;
    [SerializeField] private PanelView secondPanel;
    
    private float _firstPrice;
    private float _secondPrice;
    private float _second;

    private void Awake()
    {
        firstPanel.OnPriceChanged += str => float.TryParse(str, out _firstPrice);
        firstPanel.OnPriceChanged += str => float.TryParse(str, out _firstPrice);
        firstPanel.OnPriceChanged += str => float.TryParse(str, out _firstPrice);
        firstPanel.OnPriceChanged += str => float.TryParse(str, out _firstPrice);
    }
}
