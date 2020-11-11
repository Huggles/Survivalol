using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class GameObjectFactory : MonoBehaviour
{
    [SerializeField] GameObject virusPrefab;

    GameObject virusContainer;
    // Start is called before the first frame update
    void Start()
    {
        virusContainer = GameObject.Find("Viruses");
    }

    /**
     * Creates a virus in the viruses container game object. 
     * The position will be random within the provided area.
     */
    public void CreateVirus(Rect spawnArea)
    {
        Random
        Vector3 position = Vector3.zero;
        GameObject virus = Instantiate(virusPrefab, position, Quaternion.identity, virusContainer.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
