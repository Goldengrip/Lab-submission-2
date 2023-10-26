using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
public abstract class Weapon : MonoBehaviour
{
    private Coroutine timerCoroutine;
    protected float currChargeTime;

    private bool attackTimerDone = true;

    [SerializeField]
    protected Rigidbody owner;

    [SerializeField]
    public float contactDamage;
    [SerializeField]
    public float chargeTime;
    [SerializeField]
    public float minCharge;

    public WaitForSeconds CoolDown;

    [SerializeField]
    public float coolDown;

   

    private void OnEnable()
    {
        CoolDown = new WaitForSeconds(coolDown);
    }

    protected abstract void Attack(float chargePercent);

    protected virtual bool CanAttack()
    {
        return attackTimerDone;
    }

    private void TryAttack(float percent)
    {
        if (percent < minCharge)
        {
            return;
        }

        Attack(percent);
        StartCoroutine(CoolDownTimer());

    }

    private IEnumerator CoolDownTimer()
    {
        attackTimerDone = false;
        yield return CoolDown;
        attackTimerDone = true;
    }

    public void StartAttack()
    {
        timerCoroutine = StartCoroutine(HandleCharge());
    }

    private IEnumerator HandleCharge()
    {
        currChargeTime = 0;
        print("Start Charge");
        yield return new WaitUntil(() => attackTimerDone);
        print("CoolDownDone");

        while (currChargeTime < chargeTime)
        {
            currChargeTime += Time.deltaTime;
            yield return null;
        }
        print("Attack completed");
        TryAttack(100f);
        timerCoroutine = StartCoroutine(HandleCharge());

    }

    public void EndAttack()
    {
        StopCoroutine(timerCoroutine);
        TryAttack((currChargeTime / chargeTime) * 100);
    }
   
}
