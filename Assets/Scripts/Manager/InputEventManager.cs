using UnityEngine;

public class InputEventManager : MonoBehaviour {
    public delegate void HanldeHVInput(float x, float y);
    public static event HanldeHVInput OnHVInput;

    private void Update() {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        OnHVInput(x, y);
    }
}
