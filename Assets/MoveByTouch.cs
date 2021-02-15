using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;


public class MoveByTouch : MonoBehaviour
{
    public FixedJoystick LeftJoystick;
    //public FixedButton Button;
    public FixedTouchField TouchField;
    //protected ThirdPersonUserControl Control;
    public PlayerMovement playerMovement;

    protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;

    // Use this for initialization
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        //Control.m_Jump = Button.Pressed;
        playerMovement.hinput = LeftJoystick.input.x;

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;

        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle, Vector3.up) * new Vector3(0, 3, 4);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

    }
}
