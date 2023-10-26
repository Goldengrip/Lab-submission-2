using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI: MonoBehaviour
{
    public GameObject uiPrefab;
    public Transform target;

    private Transform ui;
    private Image healthSlider;

    private void Start()
    {
        ui = Instantiate(uiPrefab, target).transform;
        ui.SetParent(target);
        healthSlider = ui.GetChild(0).GetComponent<Image>();
    }

    private void OnHealthChanged(int maxHP, int currentHP)
    {
        if (ui != null)
        {
            float healthPercentage = currentHP / maxHP;
        }
    }
}
