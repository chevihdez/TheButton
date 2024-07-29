using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnimationsSetGray : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _square;
    [SerializeField] Image _check;

    private Color _squareDefault;
    private Color _textDefault;
    private Color _checkDefault;

    private void Start()
    {
        _squareDefault = _square.color;
        _textDefault = _text.color;
        _checkDefault = _check.color;
    }
    public void SetGray(bool value)
    {
        if (!value)
        {
            _square.color = Color.gray;
            _text.color = Color.gray;
            _check.color = Color.gray;
            toggle.interactable = false;
        }
        else
        {
            _square.color = _squareDefault;
            _text.color = _textDefault;
            _check.color = _checkDefault;
            toggle.interactable = true;

        }
    }
}
