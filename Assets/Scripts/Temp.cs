using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Vector3 startPos;
    int trackPoint;
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        switch (trackPoint)
        {
            case 0:
                transform.Translate(Vector3.up * 1 * Time.deltaTime);
                if (transform.position.y >= startPos.y + 2)
                    trackPoint = 1;
                break;
            case 1:
                transform.Translate(-Vector3.up * 1 * Time.deltaTime);
                if (transform.position.y <= startPos.y)
                    trackPoint = 0;
                break;
        }
    }
}
