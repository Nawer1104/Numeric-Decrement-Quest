using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public List<Diamond> diamondsToPlayAnim;

    public List<Diamond> diamonds;

    public List<NumberDiamond> numberDiamonds;

    public void Remove(Diamond diamond)
    {
        diamonds.Remove(diamond);

        if (diamonds.Count == 0)
        {
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1);

        FakeNumber();

        StartCoroutine(DelayToLevelUp());
    }

    IEnumerator DelayToLevelUp()
    {
        foreach (Diamond diamond in diamondsToPlayAnim)
        {
            diamond.Outro();
        }

        yield return new WaitForSeconds(2);

        GameManager.Instance.LevelUp();
    }

    private void FakeNumber()
    {
        foreach (NumberDiamond num in numberDiamonds)
        {
            num.SetText();
        }
    }
}
