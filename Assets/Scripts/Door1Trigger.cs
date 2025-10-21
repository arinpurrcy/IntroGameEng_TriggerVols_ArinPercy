using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Sam Robichaud NSCC

public class TriggerSetActive : MonoBehaviour
{
    public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        targetObject.SetActive(true);
    }
}
public class TriggerPlayAnimation : MonoBehaviour
{
    public GameObject AnimatedObject;

    private Animator _animator;

    private void Start()
    {
        _animator = AnimatedObject.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        _animator.enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        _animator.enabled = false;
    }


}
