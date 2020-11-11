using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using PubSub;
using System;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObjectFactory gameObjectFactory;

    Slider foodSlider;
    GameObject background;
    

    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.Find("Background");
        foodSlider = GameObject.Find("FoodSlider").GetComponent<Slider>();
        foodSlider.minValue = 0;
        foodSlider.maxValue = 10;

        Hub.Default.Subscribe<FoodTakenEvent>(this, FoodTakenHandler);
    }

    public void FoodTakenHandler(FoodTakenEvent foodTakenEvent)
    {
        foodSlider.value += foodTakenEvent.amount;

        MeshFilter backgroundMeshFilter = background.GetComponent<MeshFilter>();
        Debug.Log(backgroundMeshFilter.mesh.bounds);

        Rect spawnArea = new Rect(backgroundMeshFilter.mesh.bounds.min, backgroundMeshFilter.mesh.bounds.max);
        gameObjectFactory.CreateVirus(spawnArea);
    }
}
