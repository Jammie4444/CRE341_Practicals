using UnityEngine;

public class JW_Billboarding : MonoBehaviour
{
    Vector3 cameraDir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cameraDir = Camera.main.transform.forward;
        cameraDir.y = 0;
        
        transform.rotation = Quaternion.LookRotation(cameraDir);
    }
}
