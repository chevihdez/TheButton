using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnimationHandler : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Animator _animator;


    public void SendAnimationTrigger(bool value)
    {
        _animator.SetTrigger(value.ToString());

    }
}
