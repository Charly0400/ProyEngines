using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tank : MonoBehaviour
{
    public TanksSO dataSO;

    private Image _spriteImg;
    private Image _FlagImg;
    private Text _nameText;


    private void Awake()
    {
        _spriteImg = transform.Find("Sprite").GetComponent<Image>();
        _FlagImg = transform.Find("Flag").GetComponent<Image>();
        _nameText = transform.Find("ModelTxt").GetComponent <Text>();

        _spriteImg.sprite = dataSO.sprite;
        _FlagImg.sprite = dataSO.nation;
        Debug.Log(_nameText.text);
        _nameText.text = dataSO.name;
    }

}
