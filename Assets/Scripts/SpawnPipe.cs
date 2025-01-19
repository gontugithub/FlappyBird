using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    private float _heightRange = 0.45f;
    private PipePool _pool;

    private float _timer;

    private void Start()
    {
        _pool = GetComponent<PipePool>();
        SpawnPipe();
    }

    private void Update()
    {
        if (_timer > 1.5f)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {

        GameObject pipe =  _pool.GetInactiveGameObject();
        pipe.transform.position = new Vector3(1.472f, Random.Range(-_heightRange, _heightRange));
        pipe.SetActive(true);
        
        
    }
}
