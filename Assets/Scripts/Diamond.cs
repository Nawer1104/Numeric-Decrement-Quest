using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private Animator anim;

    bool isFliped = false;

    public GameObject vfx;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        anim.SetTrigger("Intro");
    }

    public void Outro()
    {
        anim.SetTrigger("Outro");
    }

    private void OnMouseEnter()
    {
        if (isFliped) return;

        isFliped = true;
        PlayVfx();
        GameManager.Instance.levels[GameManager.Instance.GetCurrentIndex()].Remove(this);
        anim.SetTrigger("Flip");
    }

    public void PlayVfx()
    {
        GameObject vfxBoom = Instantiate(vfx, transform.position, Quaternion.identity);
        Destroy(vfxBoom, 1f);
    }
}
