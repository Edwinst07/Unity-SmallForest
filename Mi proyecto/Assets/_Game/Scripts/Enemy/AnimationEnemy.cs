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
        _anim.SetBool("Walk", walkValue);
    }

    public void back_by_attack(bool jumpValue)
    {
        _anim.SetBool("Jump", jumpValue);
    }
    
    public void attack(bool attackValue)
    {
        _anim.SetBool("Attack", attackValue);
    }

}
