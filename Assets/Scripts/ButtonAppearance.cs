using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAppearance : MonoBehaviour
{
    [SerializeField] public GameObject Option_1;
    [SerializeField] public int revealDelay;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        Option_1.SetActive(false);
        yield return new WaitForSeconds(revealDelay);
        Option_1.SetActive(true);
    }
}
