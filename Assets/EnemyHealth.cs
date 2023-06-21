using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private float totalHealht = 100f;

    private float _health;

    private void Start()
    {
        _health = totalHealht;
        InitHealth();
    }

    public void ReduceHealth(float damage)
    {
        _health -= damage;
        InitHealth();
        _animator.SetTrigger("takeDamage");
        if(_health <= 0)
        {
            Die();
        }
    }

    private void InitHealth()
    {
        healthSlider.value = _health / totalHealht;
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }


}
