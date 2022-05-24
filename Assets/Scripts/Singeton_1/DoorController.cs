using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
    }
    private void OnDoorwayOpen()
    {
        transform.position = new Vector3(0, 10, 0);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
