using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableImage : MonoBehaviour
{
    public GameObject Object;

    public void Disable()
    {
        Object.SetActive(false);
    }
}
