using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class BulbAnimationHandler : MonoBehaviour
{
    [SerializeField] Animator _bulbAnimator;
    [SerializeField] Toggle _animToggle;
    [SerializeField] Toggle _graphicsToggle;
    private bool toggleTrue = true;
    private bool toggleDown = false;

    
    public void SendAnimationTrigger(bool value)
    {
        



        toggleDown = false;
        _bulbAnimator.SetBool("ToggleDown", toggleDown);

    }

    public void SendToggle(bool value)
    {
        _bulbAnimator.SetBool("ToggleTrue", value);
        toggleTrue = value;
    }

    public void OnPressed()
    {
        if (!toggleTrue)
        {
            toggleDown = !toggleDown;
            _bulbAnimator.SetBool("ToggleDown", toggleDown);
        }
    }

    public void SetAnimBasic()
    {
        
        if (_animToggle.isOn == false || _graphicsToggle.isOn == false)
        {
            _bulbAnimator.SetBool("IsBasic", true);
        }
        else
        {
            _bulbAnimator.SetBool("IsBasic", false);
        }
        
    }
}
