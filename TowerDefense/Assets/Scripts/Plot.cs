using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Color hoverColor;

    private GameObject tower;
    private Color startColor;

    private void Start()
    {
        startColor = spriteRenderer.color;
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = hoverColor;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = startColor;
    }

    private void OnMouseDown()
    {
        if (tower != null)
        {
            return;
            //TODO make a upgrade menu when clicked in a tower
        }

        GameObject towerToBuild = BuildManager.instance.GetSelectedTower();
        tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }
}