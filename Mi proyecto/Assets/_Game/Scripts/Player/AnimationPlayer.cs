using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void SetHorizontal(float horizontalValue)
    {
        _anim.SetFloat("Horizontal", horizontalValue);
    }

    public void SetVertical(float verticalValue)
    {
        _anim.SetFloat("Vertical", verticalValue);
    }

    public void SetJump(bool jumpValue)
    {
        _anim.SetBool("TouchingFloor", jumpValue);
    }

}
