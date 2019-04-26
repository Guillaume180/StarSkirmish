using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    
	public void Buy1_99()
    {
        Purchase.Instance.Buy1_99();
    }

    public void Buy19_99()
    {
        Purchase.Instance.Buy19_99();
    }

    public void Buy24_99()
    {
        Purchase.Instance.Buy24_99();
    }

    public void Buy49_99()
    {
        Purchase.Instance.Buy49_99();
    }

    public void Buy99_99()
    {
        Purchase.Instance.Buy99_99();
    }
    
}
