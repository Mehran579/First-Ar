using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class EntityManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    ARRaycastManager raycastManager;
    public GameObject playerPrefab;
    GameObject Player;
    private List<ARRaycastHit> hitResultsList = new List<ARRaycastHit>();
    private bool isPlaced = false;
    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
            return;

        Vector2 screenPos = Touchscreen.current.primaryTouch.position.ReadValue();
        //raycastManager.Raycast(screenPos, hitResultsList, TrackableType.PlaneWithinPolygon);

        if (raycastManager.Raycast(screenPos, hitResultsList, TrackableType.PlaneWithinPolygon))
        {
            Vector3 hitPoint = hitResultsList[0].pose.position;
            if (!isPlaced)
            {
                isPlaced = true;
                Player = Instantiate(playerPrefab, hitPoint, hitResultsList[0].pose.rotation);
            }
        }
    }
}
