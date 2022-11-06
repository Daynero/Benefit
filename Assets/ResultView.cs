using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResultView : MonoBehaviour
{
    [SerializeField] private Button closeButton;
    [SerializeField] private TextMeshProUGUI resultText;

    private void Awake()
    {
        closeButton.onClick.AddListener(() => gameObject.SetActive(false));
    }

    public void SetView(int number, int result)
    {
        resultText.text = number == 0
            ? "Товары одинаковой стоимости"
            : "Товар №" + number + " выгодней на " + result + "%";
    }
}
