using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    [SerializeField] private AudioClip attackSFX;
    [SerializeField] private AudioSource audioSource;

    public string CharName
    {
        get { return charName; }
    }

    public override int Attack()
    {
        if (attackSFX != null && audioSource != null)
        {
            audioSource.PlayOneShot(attackSFX);
        }

        return base.Attack();
    }
}
