using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public GameManager GameManager;

    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0") + "                                                                                 L bozo";
            if (GameManager.Instance == null)
            {
                Debug.LogError("GameManager NOT detected");

                int mouseSensitivity = (int)v;
                GameManager.mouseSensitivity = mouseSensitivity;
            }
            else
            {
                Debug.Log("GameManager detected");
                int mouseSensitivity = (int)v;
                GameManager.Instance.mouseSensitivity = mouseSensitivity;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
