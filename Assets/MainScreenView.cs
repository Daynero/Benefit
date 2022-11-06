using UnityEngine;
using UnityEngine.UI;

public class MainScreenView : MonoBehaviour
{
    [SerializeField] private PanelView firstPanel;
    [SerializeField] private PanelView secondPanel;
    [SerializeField] private Button confirmButton;
    [SerializeField] private ResultView popUpResult;

    private void Awake()
    {
        confirmButton.onClick.AddListener(ConfirmClick);
    }

    private void ConfirmClick()
    {
        float.TryParse(firstPanel.GetPrice(), out float firstPrice);
        float.TryParse(secondPanel.GetPrice(), out float secondPrice);
        float.TryParse(firstPanel.GetWeight(), out float firstWeight);
        float.TryParse(secondPanel.GetWeight(), out float secondWeight);

        if (firstPrice == 0 || firstWeight == 0 || secondPrice == 0 || secondWeight == 0) return;

        float first = firstPrice * 1000 / firstWeight;
        float second = secondPrice * 1000 / secondWeight;

        float difference = first - second;

        popUpResult.gameObject.SetActive(true);
        
        switch (difference)
        {
            case 0:
                popUpResult.SetView(0,0);
                break;
            case > 0:
                popUpResult.SetView(2, (int)(first / second * 100 - 100));
                break;
            default:
                popUpResult.SetView(1, (int)(second / first * 100 - 100));
                break;
        }
    }
}