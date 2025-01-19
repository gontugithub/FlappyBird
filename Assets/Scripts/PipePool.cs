using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PipePool : MonoBehaviour
{
    // Need a list for having the pipes prefabs

    private List<GameObject> pipespool;

    public GameObject pipeprefab;

    public uint poolsize;

    public bool shouldExpand = true;


    void Awake()
    {
        Init(poolsize);
    }

    public void Init(uint _size)
    {
        pipespool = new List<GameObject>();

        for (int i = 0; i < _size; i++)
        {
            AddPipeToPool();
        }
    }

    public GameObject GetInactiveGameObject()
    {
        foreach (GameObject o in pipespool)
        {
            if (o.activeInHierarchy == false)
            {
                return o;
            }
        }

        if (shouldExpand)
        {
            return AddPipeToPool();
        }

        // if can't expand, that must be handled in the other script
        return null;
    }

    private GameObject AddPipeToPool()
    {

       // Vector3 spawnPos = transform.position + new Vector3(0,Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(pipeprefab, transform);
        pipe.SetActive(false);
        pipespool.Add(pipe);
        return pipe;
    }

}
