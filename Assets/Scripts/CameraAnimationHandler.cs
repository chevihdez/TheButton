using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnimationHandler : MonoBehaviour
{
    [SerializeField] Animator _cameraAnimator;

   
    public void Shake()
    {
        _cameraAnimator.SetTrigger("Shake");
    }
}
