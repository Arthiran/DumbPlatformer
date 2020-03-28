using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTriggerScript : MonoBehaviour
{
    public GameObject TriggerText;
    public int triggerCounterVal;
    private int triggerCounter = 0;
    private Animator animator;

    private void Start()
    {
        animator = TriggerText.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<MovementScript>() != null)
        {
            if (triggerCounter == triggerCounterVal)
            {
                TriggerText.SetActive(true);
                animator.SetBool("FadeOut", true);
                StartCoroutine(DisableText());
            }
            triggerCounter++;
        }
    }

    private IEnumerator DisableText()
    {
        yield return new WaitForSeconds(5.0f);
        TriggerText.SetActive(false);
    }
}
