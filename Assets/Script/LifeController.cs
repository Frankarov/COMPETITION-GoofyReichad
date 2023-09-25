using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeController : MonoBehaviour
{

    [SerializeField] GameObject dieCanvas;

    [Header("LifePar")]
    [SerializeField] private float maxLife = 100f;
    public float currentLife;
    [SerializeField] private float decreaseDuration = 0.5f;
    [SerializeField] private float increaseDuration = 0.5f;

    [Header("UIPar")]
    [SerializeField] private Text lifeText;

    private void Start()
    {
        currentLife = maxLife;
        UpdateLifeText();

    }

    public void LifeGone(float damage)
    {
        StartCoroutine(DecreaseLife(damage));
    }

    public void LifeGain(float healAmount)
    {
        StartCoroutine(IncreaseLife(healAmount));
    }

    private IEnumerator DecreaseLife(float damage)
    {
        float damagePerTick = damage / decreaseDuration;
        float elapsedTime = 0f;
        float totalDamageApplied = 0f;
        while(elapsedTime < decreaseDuration)
        {
            float currentDamage = damagePerTick * 0.02f /** Time.deltaTime*/;
            totalDamageApplied += currentDamage;
            Debug.Log(totalDamageApplied);
            //elapsedTime += Time.deltaTime;
            while (totalDamageApplied >= 1f)
            {
                currentLife -= 1;
                totalDamageApplied -= 1f;
                UpdateLifeText();
                if(currentLife <= 0)
                {
                currentLife = 0;
                break;
                }
            }


            elapsedTime += 0.01f;
            yield return null;

        }

    } //close ienumerator

    private IEnumerator IncreaseLife(float healAmount)
    {
        float healPerTick = healAmount / increaseDuration;
        float elapsedTime = 0f;
        float totalHealApplied = 0f;

        if(currentLife < 100)
        {
        while (elapsedTime < increaseDuration)
        {
            float currentHeal = healPerTick * 0.02f;
            totalHealApplied += currentHeal;
            Debug.Log(totalHealApplied);


            while (totalHealApplied >= 1f)
            {
                currentLife += 1;
                totalHealApplied -= 1f;
                UpdateLifeText();
                if (currentLife >= maxLife)
                {
                    currentLife = maxLife;
                    break;
                }
            }

            elapsedTime += 0.01f;
            yield return null;
        }
        }


    }

    private void UpdateLifeText()
    {
        lifeText.text = currentLife.ToString();
        Debug.Log("tesupdatelifetext");
    }

    private void UpdateLifeText100()
    {
        lifeText.text = currentLife.ToString("100");
    }

    private void Update()
    {
        if (currentLife > 100)
        {
            currentLife = 100;
            UpdateLifeText();
        }

        if(currentLife <= 0)
        {
            currentLife = 0;
            UpdateLifeText();
            dieCanvas.SetActive(true);
            Time.timeScale = 0f;
            
        }

    }

}
