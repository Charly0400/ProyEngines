using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image image;

    private void ChangeColor()
    {
        image.color = Color.red;
    }

    private void OnEnable()
    {
        Observer.onLog.AddListener(ChangeColor);
    }
    private void OnDisable()
    {
        Observer.onLog.RemoveListener(ChangeColor);
    }
}
