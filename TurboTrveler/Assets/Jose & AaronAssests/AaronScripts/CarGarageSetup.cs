using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarGarageSetup : MonoBehaviour
{
   /* wheelCollider wheelfrontleft;
    wheelCollider wheelfrontright;
    wheelCollider wheelrearleft;
    wheelCollider wheelrearright;

    //JointSpring carSpring;

    public GameObject wheelFrontLeft;
    public GameObject wheelFrontRight;
    public GameObject wheelRearLeft;
    public GameObject wheelRearRight;

    //front wheels
    float gripfront;
    public Slider gripFrontSlider;
    float suspensionfront;
    public Slider suspensionFrontSlider;
    float springfront;
    public Slider springFrontSlider;
    float damperfront;
    public Slider damperFrontSlider;
    float positionfront;
    public Slider positionFrontSlider;

    //Rear wheels
    float griprear;
    public Slider gripRearSlider;
    float suspensionrear;
    public Slider suspensionRearSlider;
    float springrear;
    public Sider springRearSlider;
    float damperrear;
    public Slider damperRearSlider;
    float positionrear;
    public Slider positionRearSlider;


    void Awake()
    {
        wheelfrontleft = wheelFrontLeft.gameObject.GetComponent<WheelCollider>();
        wheelfrontright = wheelFrontRight.gameObject.GetComponent<WheelCollider>();
        wheelrearleft = wheelRearLeft.gameObject.GetComponent<WheelCollider>();
        wheelrearright = wheelRearRight.gameObject.GetComponent<WheelCollider>();
    }

    void Start()
    {
        //FRONT WHEELS

        //Grip
        gripfront = PlayerPrefs.GetFloat("gripfront", 0);
        if (gripfront < 0.5f)
        {
            gripfront = 1f;
        }
        gripFrontSlider.value = gripfront;
        ValueChangeCheckFrontGrip();

        //Suspension
        suspensionfront = PlayerPrefs.GetFloat("suspensionfront", 0);
        if (suspensionfront < 0.1f)
        {
            suspensionfront = 0.3f;
        }
        suspensionFrontSlider.value = suspensionfront;
        ValueChangeCheckFrontSuspension();

        //Spring
        springFront = PlayerPrefs.Getfloat("springfront", 0);

        if (springfront < 100f)
        {
            springfront = 25500f;
        }
        springFrontSlider.value = springfront;
        ValueChangeCheckFrontSpring();

        //Damper
        damperfront = PlayerPrefs.Getfloat("damperfront", 0);

        if (damperfront < 100f)
        {
            damperfront = 1800f;
        }
        damperFrontSlider.value = damperfront;
        ValueChangeCheckFrontDamper();

        //Position
        positionfront = PlayerPrefs.GetFloat("positionfront", 0);

        if (positionfront < 0.1f)
        {
            positionfront = 0.5f;
        }
        positionFrontSlider.value = positionfront;
        ValueChangeCheckFrontPosition();

        //REAR WHEELS

        //Grip
        griprear = PlayerPrefs.GetFloat("griprear", 0);

        if (griprear < 0.5f)
        {
            griprear = 1f;
        }
        gripRearSlider.value = griprear;
        ValueChangeCheckRearGrip();

        //Suspension
        suspensionrear = PlayerPrefs.GetFloat("suspensionrear", 0);

        if (suspensionrear < 0.1f)
        {
            suspensionrear = 0.3f;
        }
        suspensionRearSlider.value = suspensionrear;
        ValueChangeCheckRearSuspension;

        //Spring
        springrear = PlayerPrefs.GetFloat("springrear", 0);

        if (springrear < 100f)
        {
            springrear = 25500f;
        }
        springRearSlider.value = springrear;
        ValueChangeCheckRearSpring();

        //Damper
        damperrear = PlayerPrefs.GetFloat("damperrear", 0);

        if (damperrear < 100f)
        {
            damperrear = 1800f;
        }
        damperRearSlider.value = damperrear;
        ValueChangeCheckRearDamper();

        //Position
        positionrear = PlayerPrefs.GetFloat("postionrear", 0);

        if (positionrear < 0.1f)
        {
            positionrear = 0.5f;
        }
        positionRearSlider.value = positionrear;
        ValueChangeCheckRearPosition();

        //front wheels

        gripFrontSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckFrontGrip();
        });

        suspensionFrontSlider.onValueChanged.AddListener(delegate
       {
           ValueChangeCheckFrontSuspension();
       });

        damperFrontSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckFrontDamper();
        });

        positionFrontSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckFrontPosition();
        });

        //Rear Wheels

        gripRearSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckRearGrip();
        });

        suspensionRearSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckRearSuspension();
        });

        springRearSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckRearSpring();
        });

        damperRearSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckRearDamper();
        });

        positionRearSlider.onValueChanged.AddListener(delegate
        {
            ValueChangeCheckRearPosition();
        });
    }
    //FRONT WHEELS

    void ValueChangeCheckFrontGrip()
    {
        //Grip
        gripfront = gripFrontSlider.value;

        WheelFrictionCurve WFC;
        //Left
        WFC = wheelfrontleft.forwardFriction;
        WFC.stiffness = gripfront;
        wheelfrontleft.forwardFriction = WFC;

        PlayerPrefs.SetFloat("gripfront", gripfront);
    }

    void ValueChangeCheckFrontSuspension()
    {
        //Suspension
        suspensionfront = suspensionFrontSlider.value;
        //Left
        wheelfrontleft.suspensionDistance = suspensionfront;
        //Right
        wheelfrontright.suspensionDistance = suspensionfront;

        PlayerPrefs.SetFloat("suspensionfront", suspensionfront);
    }

    void ValueChangeCheckFrontSpring ()
    {
        //Spring
        springFront = springFrontSlider.value;
        //Left
        carSpring = wheelfrontleft.suspensionSpring;
        carSpring.spring = springfront;
        wheelfrontleft.suspensionSpring = carSpring;
        //Right
        carSpring = wheelfrontright.suspensionSpring;
        carSpring.spring = springfront;
        wheelfrontright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("springfront", springfront);
    }

    void ValueChangeCheckFrontDamper ()
    {
        //Damper
        damperfront = damperFrontSlider.value;
        //Left
        carSpring.damper = damperfront;
        wheelfrontleft.suspensionSpring = carSpring;
        //Right
        wheelfrontright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("damperfront", damperfront);
    }

    void ValueChangeCheckFrontPosition()
    {
        //Position
        positionfront = positionFrontSlider.value;
        //Left
        carSpring.targetPosition = positionfront;
        wheelfrontleft.suspensionSpring = carSpring;
        //Right
        wheelfrontright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("postionfront", positionfront);
    }

    //REAR WHEELS

    void ValueChangeCheckRearGrip ()
    {
        //Grip
        griprear = gripFrontSlider.value;

        WheelFrictionCurve WFC;
        //Left
        WFC = wheelrearleft.forwardFriction;
        WFC.stiffness = griprear;
        wheelrearleft.forwardFriction = WFC;

        //Right
        WFC = wheelrearleft.forwardFriction;
        WFC.stiffness = griprear;
        wheelrearleft.forwardFriction = WFC;

        PlayerPrefs.SetFloat("griprear", griprear);
    }

    void ValueChangeCheckRearSuspension()
    {
        //Suspension
        suspensionrear = suspensionRearSlider.value;
        //Left
        wheelrearleft.suspensionDistance = suspensionrear;
        //Right
        wheelrearright.suspensionDistance = suspensionrear;

        PlayerPrefs.SetFloat("suspensionrear", suspensionrear);
    }

    void ValueChangeCheckRearSpring()
    {
        //Spring
        springRear = springRearSlider.value;
        //Left
        carSpring = wheelrearleft.suspensionSpring;
        carSpring.spring = springrear;
        wheelrearleft.suspensionSpring = carSpring;
        //Right
        carSpring = wheelrearright.suspensionSpring;
        carSpring.spring = springrear;
        wheelrearright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("springrear", springrear);
    }

    void ValueChangeCheckRearDamper()
    {
        //Damper
        damperrear = damperRearSlider.value;
        //Left
        carSpring.damper = damperrear;
        wheelrearleft.suspensionSpring = carSpring;
        //Right
        wheelrearright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("damperrear", damperrear);
    }

    void ValueChangeCheckRearPosition()
    {
        //Position
        positionrear = positionRearSlider.value;
        //Left
        carSpring.targetPosition = positionrear;
        wheelrearleft.suspensionSpring = carSpring;
        //Right
        wheelrearright.suspensionSpring = carSpring;

        PlayerPrefs.SetFloat("postionrear", positionrear);
    }*/
}
