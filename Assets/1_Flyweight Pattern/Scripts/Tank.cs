using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tank : MonoBehaviour
{
    public TanksSO dataSO;

    private Image _spriteImg;
    private Image _FlagImg;
    private TextMeshProUGUI _nameText;


    private void Awake()
    {
        _spriteImg = transform.Find("Sprite").GetComponent<Image>();
        _FlagImg = transform.Find("Flag").GetComponent<Image>();
        _nameText = transform.Find("ModelTxt").GetComponent <TextMeshProUGUI>();

        _spriteImg.sprite = dataSO.sprite;
        _FlagImg.sprite = dataSO.nation;
        _nameText.text = dataSO.name;
    }

}
