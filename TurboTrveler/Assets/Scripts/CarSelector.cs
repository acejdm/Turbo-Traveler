using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour
{

    public GameObject blueCar;
    public GameObject redCar;
    public GameObject grayCar;

    public int carSelected;

    void Start()
    {
        blueCar.SetActive(true);
        redCar.SetActive(false);
        grayCar.SetActive(false);

        carSelected = 1;
    }

    public void loadBlue()
    {
        blueCar.SetActive(true);
        redCar.SetActive(false);
        grayCar.SetActive(false);

        carSelected = 1;
    }

    public void loadRed ()
    {
        blueCar.SetActive(false);
        redCar.SetActive(true);
        grayCar.SetActive(false);

        carSelected = 2;
    }

    public void loadGray ()
    {
        blueCar.SetActive(false);
        redCar.SetActive(false);
        grayCar.SetActive(true);

        carSelected = 3;
    }
}
