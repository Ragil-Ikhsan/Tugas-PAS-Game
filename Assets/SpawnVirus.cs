using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVirus : MonoBehaviour
{
    public GameObject virus;
    public float WaktuMinimal, WaktuMaximal;
    public float PosisiMinimal, PosisiMaximal;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator MunculVirus()
    {
        Instantiate(virus, transform.position + Vector3.right * Random.Range(PosisiMinimal, PosisiMaximal)
            , Quaternion.identity);
        yield return new WaitForSeconds(Random.Range(WaktuMinimal,WaktuMaximal));
        StartCoroutine(MunculVirus());
    }
}
