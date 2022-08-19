using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 45f;
    public float panBorderThickness = 10f;
    
    public float scrollSpeed = 5f;
    public float minY = 25f;
    public float maxY = 100f;
    public float minX = 16f;
    public float maxX = 96f;
    public float minZ = 46f;
    public float maxZ = 126f;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GameIsOver)
        {
            this.enabled = false;
            return;
        }

        if (Input.GetKey("w") || Input.GetKey("up") || Input.mousePosition.y >= Screen.height - panBorderThickness){
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("s") || Input.GetKey("down") || Input.mousePosition.y <= panBorderThickness){
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("d") || Input.GetKey("right") || Input.mousePosition.x >= Screen.width - panBorderThickness){
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("a") || Input.GetKey("left") || Input.mousePosition.x <=  panBorderThickness){
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }
        
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position; 

        pos.y -= scroll * 1000 *scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        if(Input.GetKey("h"))
        {
            pos.y = 90f;
            pos.x = 56f;
            pos.z = 46f;
        }

        transform.position = pos;

    }
}
