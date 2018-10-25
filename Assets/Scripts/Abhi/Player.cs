using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;

//  Chiranjeevi Code for Testing
    private NavMeshAgent navMesh;
    private Transform targetedEnemy;
    private Ray shootray;
    private RaycastHit shoothit;
    private bool enemyclicked;
/*
 void Awake()
    {
        navMesh = GetComponent<NavMeshAgent> ();
    }

    void Update()
      {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          RaycastHit hit;
          if(Input.GetButtonDown("Fire1")){
              if(Physics.Raycast(ray, out hit, 100))
              {
                  if(hit.collider.CompareTag("Duck"))
                  {
                      targetedEnemy = hit.transform;
                      enemyclicked = true;
                  }
                  else
                  {
                      enemyclicked = false;
                      navMesh.destination = hit.point;
                      navMesh.Resume();
                  }
              }
          }
          if(enemyclicked)
          {
              MoveandShoot();
          }
      }

      private void MoveandShoot()
      {
          if(targetedEnemy == null)
              return;
          navMesh.destination = targetedEnemy.position;
          Input.GetButtonDown("Fire1");
      }
      */
    //   Chiranjeevi Code for Testing

    // Use this for initialization


    // Update is called once per frame
    // void Update()
    // {
    //     //<<<<<<< HEAD
    //     /* Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
    //      newPos.z = transform.position.z;
    //      transform.position = newPos;
    //      */
    // }
    //=======


    //>>>>>>> f5db390d258bf33ac12823dcf3218a0a67fbc508

    //on awake

    // private void Awake()
    // {
    //     //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

    // }

    /*
        // Handle mouse click
        public void onShoot()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("Mouse click");
                sendLocation();
            }
        }

        // Send location co-ordinates
        public Vector2 sendLocation()
        {
            Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

            System.Console.WriteLine(mousePosition);
            Debug.Log(mousePosition);

            return mousePosition;
        }


        public void OnCollisionEnter(Collision collision)
        {
            Debug.Log("COLLIDE");
            Destroy(collision.gameObject);

        }
        */
}

