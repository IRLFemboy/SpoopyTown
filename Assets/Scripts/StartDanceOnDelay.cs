using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDanceOnDelay : MonoBehaviour
{
    public float delaymin;
    public float delaymax = 3;

    Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();

        StartCoroutine(StartDance());
    }

    IEnumerator StartDance()
    {
        yield return new WaitForSeconds(Random.Range(delaymin, delaymax));
        anim.SetTrigger("StartThingy");
    }
}
