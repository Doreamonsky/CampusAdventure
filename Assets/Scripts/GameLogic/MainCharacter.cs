using UnityEngine;

public class MainCharacter : MonoBehaviour,ICharacter {
    public Animator characterAnimator;


    private void OnEnable() {
        InputEventManager.OnHVInput += Move;
    }
    private void OnDisable() {
        InputEventManager.OnHVInput -= Move;
    }

    public void Move(float x, float y) {
        Vector3 WorldDir = new Vector3(x,0,y);
        Vector3 LocalDir = transform.InverseTransformDirection(WorldDir); //Project WorldDir to Local 

        if(WorldDir.magnitude !=0)
            transform.rotation = Quaternion.LookRotation(WorldDir.normalized * 150 + transform.position);
        
        characterAnimator.SetFloat("Y", Mathf.Abs(LocalDir.z));
    }


}
