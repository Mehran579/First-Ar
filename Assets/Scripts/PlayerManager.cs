using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject head;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Camera.main.transform.position - transform.position;
        head.transform.LookAt(head.transform.position + dir);
        dir.y = 0;
        transform.LookAt(transform.position + dir);
    }
}
