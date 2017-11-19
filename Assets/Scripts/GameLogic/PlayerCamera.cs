using UnityEngine;
[System.Serializable]
public class PlayerCameraProperty{
    public float distanceToTarget = 15;
}

public class PlayerCamera : MonoBehaviour {
    public static PlayerCamera Instance;

    public PlayerCameraProperty playerCameraProperty;
    public GameObject target;
    
    public static void Init(GameObject targetLinkedToCamera,PlayerCameraProperty customCameraPropety){
        GameObject newCameraObject = new GameObject("MainCamera", typeof(Camera), typeof(AudioListener),typeof(PlayerCamera));
        PlayerCamera newInstantiatedCamera = newCameraObject.GetComponent<PlayerCamera>();
        newInstantiatedCamera.target = targetLinkedToCamera;
        newInstantiatedCamera.playerCameraProperty = customCameraPropety;
    }

    private void Start() {
        transform.rotation = Quaternion.Euler(45, 0, 0);
    }

    private void LateUpdate() {
        Vector3 DesirePoisition = target.transform.position + new Vector3(0, 8, -8);
        transform.position = Vector3.Lerp(transform.position,DesirePoisition,Time.deltaTime*2);
    }
}
