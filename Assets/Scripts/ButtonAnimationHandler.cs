using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationHandler : MonoBehaviour
{
    [SerializeField] Animator _buttonAnimator;
    private bool toggleTrue = true;
    private bool toggleDown = false;

    [SerializeField] GameObject _fullButton;
    [SerializeField] GameObject _full2Button;
    [SerializeField] GameObject _wireframeButton;

    public void SendAnimationTrigger(bool value)
    {
        
        _buttonAnimator.SetBool("ToggleTrue", value);
        toggleTrue = value;


        toggleDown = false;
        _buttonAnimator.SetBool("ToggleDown", toggleDown);

    }

    public void OnPressed()
    {
        if (!toggleTrue)
        {
            toggleDown = !toggleDown;
            _buttonAnimator.SetBool("ToggleDown", toggleDown);
        }
    }

    public void EnableFull(bool value)
    {
        _fullButton.SetActive(value);
        _full2Button.SetActive(value);
        _wireframeButton.SetActive(!value);
    }
}
