using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private Animator animator;
    private CanvasGroup cv;

    private void Start()
    {
        animator = GetComponent<Animator>();
        cv = GetComponent<CanvasGroup>();

        cv.interactable = false;
        cv.blocksRaycasts = false;
    }

    public void Show()
    {
        animator.Play("FadeInUI");

        cv.interactable = true;
        cv.blocksRaycasts = true;
    }

    public void Hide()
    {
        animator.Play("FadeOutUI");

        cv.interactable = false;
        cv.blocksRaycasts = false;
    }
}