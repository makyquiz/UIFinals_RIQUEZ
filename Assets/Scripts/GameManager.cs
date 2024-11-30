using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ninja;
    public GameObject dummy;

    public GameObject glasses;
    public GameObject glasses2;
    public GameObject hair;
    public GameObject hair2;

    public GameObject customizeB;
    public GameObject transformB;
    public GameObject animateB;

    public GameObject customizePanel;
    public GameObject transformPanel;
    public GameObject animatePanel;

    public GameObject backButton;

    public Animator animator;

    private void Start()
    {
        backButton.SetActive(false);

        customizePanel.SetActive(false);
        transformPanel.SetActive(false);
        animatePanel.SetActive(false);

        glasses.SetActive(false);
        glasses2.SetActive(false);
        hair.SetActive(false);
        hair2.SetActive(false);

        ninja.SetActive(true);
        dummy.SetActive(false);
    }

    public void CustomizePanelAppear()
    {
        customizePanel.SetActive(true);
        backButton.SetActive(true);

        transformB.SetActive(false);
        animateB.SetActive(false);
        customizeB.SetActive(false);
    }

    public void TransformPanelAppear()
    {
        transformPanel.SetActive(true);
        backButton.SetActive(true);

        customizeB.SetActive(false);
        animateB.SetActive(false);
        transformB.SetActive(false);
    }

    public void AnimatePanelAppear()
    {
        animatePanel.SetActive(true);
        backButton.SetActive(true);

        transformB.SetActive(false);
        customizeB.SetActive(false);
        animateB.SetActive(false);
    }

    public void Back()
    {
        // Hide all panels
        transformPanel.SetActive(false);
        customizePanel.SetActive(false);
        animatePanel.SetActive(false);

        // Show all buttons again
        transformB.SetActive(true);
        animateB.SetActive(true);
        customizeB.SetActive(true);

        // Hide the back button
        backButton.SetActive(false);
    }

    public void HairAppear()
    {
        hair.SetActive(!hair.activeSelf);
        hair2.SetActive(!hair2.activeSelf);
    }

    public void GlassesAppear()
    {
        glasses.SetActive(!glasses.activeSelf);
        glasses2.SetActive(!glasses2.activeSelf);
    }

    public void IncreaseSize()
    {
        ninja.transform.localScale += new Vector3(25f, 25f, 25f);
        dummy.transform.localScale += new Vector3(25f, 25f, 25f);
    }

    public void DecreaseSize()
    {
        ninja.transform.localScale -= new Vector3(25f, 25f, 25f);
        dummy.transform.localScale -= new Vector3(25f, 25f, 25f);

        if (ninja.transform.localScale.x < 0.1f)
        {
            ninja.transform.localScale = new Vector3(25f, 25f, 25f);
            dummy.transform.localScale = new Vector3(25f, 25f, 25f);
        }
    }

    public void ChangeModel()
    {
        bool isNinjaActive = ninja.activeSelf;

        ninja.SetActive(!isNinjaActive);
        dummy.SetActive(isNinjaActive);
    }
}
