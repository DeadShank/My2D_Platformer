using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private bool _isAttack;
    [SerializeField] private AudioSource attackSound;

    public bool IsAttack
    {
        get
        {
            return _isAttack;
        }
    }

    public void FinishAttack()
    {
        _isAttack = false;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _isAttack = true;
            animator.SetTrigger("attack");
            attackSound.Play();
        }
    }
}
