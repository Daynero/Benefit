using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanelView : MonoBehaviour
{
    [SerializeField] private Button clearWeightButton;
    [SerializeField] private Button clearPriceButton;
    [SerializeField] private TMP_InputField weightInput;
    [SerializeField] private TMP_InputField priceInput;

    public event Action<string> OnWeightChanged;
    public event Action<string> OnPriceChanged;

    private void Awake()
    {
        weightInput.onValueChanged.AddListener(str => OnWeightChanged?.Invoke(str));
        priceInput.onValueChanged.AddListener(str => OnPriceChanged?.Invoke(str));
    }

    public string GetPrice() => priceInput.text;
    public string GetWeight() => weightInput.text;
}
