using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePopUp : MonoBehaviour
{
    public GameObject popup;

    public void DisableUI()
    {
        popup.SetActive(false);
    }
}
