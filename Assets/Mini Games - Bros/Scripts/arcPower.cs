using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arcPower : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        StartCoroutine(destroying());
    }

    IEnumerator destroying()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
