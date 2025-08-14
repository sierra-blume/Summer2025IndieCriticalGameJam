using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameManager GameManager;

    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    private int defaultMouseSensitivity = 250;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.mouseSensitivity = defaultMouseSensitivity;
        _slider.value = defaultMouseSensitivity;
        _sliderText.text = defaultMouseSensitivity.ToString("0");

        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0") + "                                                                                 L bozo";
            GameManager.mouseSensitivity = (int)v;
        });
    }
}
