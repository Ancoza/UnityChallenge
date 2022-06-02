using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class CreateCar : MonoBehaviour
{
    private Vector3 position;
    [SerializeField]
    private List<GameObject> cars;

    private float _timeTilNextSpawn = 2;
    private float _timer;
    public bool isP;

    void Update()
    {
        isP = ModePlayer.sharedInstance.isPlaying;
        if (isP)
        {
            _timer += Time.deltaTime;
            CreateCars();
        }
    }

    void CreateCars()
    {
        if (_timer >= _timeTilNextSpawn)
        {
            int range = Random.Range(0, 4);
            Vector3 offset = transform.position + new Vector3(Random.Range(-6, 6), 0, 0);
            for (int i = 0; i < cars.Count; i++)
            {
                if (range == i)
                {
                    Instantiate(cars[i],offset,new Quaternion(0,180,0,0));
                    _timeTilNextSpawn = Random.Range(3, 5);
                }
            }
            _timer = 0;
        }
    }
}
