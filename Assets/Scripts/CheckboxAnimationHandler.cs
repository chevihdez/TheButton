using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckboxAnimationHandler : MonoBehaviour
{
    [SerializeField] private Animator _checkboxAnimator;

    public void Checkbox(bool value)
    {
        _checkboxAnimator.SetBool("IsOn", value);
    }
}
