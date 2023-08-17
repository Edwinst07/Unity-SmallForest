using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void walk(bool walkValue)
    {
        _anim.SetBool("walk", walkValue);
    }

    public void back_by_attack(bool jumpValue)
    {
        _anim.SetBool("Jump", jumpValue);
    }
    

}
