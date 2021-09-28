using UnityEngine;

public class FlyUpSlow : MonoBehaviour
{
    public GameObject flyingObject;
    
    private void Update() {
        Vector3 objectPos = flyingObject.transform.position;
        objectPos += Vector3.up * (Time.deltaTime * 5f);
        flyingObject.transform.position = objectPos;
    }
}
