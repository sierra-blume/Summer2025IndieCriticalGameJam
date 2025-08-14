using UnityEngine;
using TMPro;
using System.Runtime.Serialization;

public class ObjectListDisplayUI : MonoBehaviour
{
    public CameraTargetDetect CameraTargetDetect;
    public TextMeshProUGUI displayText;

    private string lastOutput = "";


    void Update()
    {
        if (CameraTargetDetect == null || displayText == null)
        {
            Debug.Log("Missing Refs");
            return;
        }

        string output = "";

        foreach (GameObject obj in CameraTargetDetect.currentTargets)
        {
            if (obj != null)
                output += obj.name + "\n";
        }

        // Only update UI if the string has changed (performance boost)
        if (output != lastOutput)
        {
            displayText.text = output;
            lastOutput = output;
        }
    }
}