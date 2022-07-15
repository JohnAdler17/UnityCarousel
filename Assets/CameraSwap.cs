using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public GameObject[] buttons;

    public void MainCameraButtons()
    {
        buttons[0].SetActive(false); // View Carousel Button
        buttons[1].SetActive(false); // Ride Tiger Button
        buttons[2].SetActive(false); // Ride Teacup Button
        buttons[3].SetActive(false); // Ride Car Button
        buttons[4].SetActive(false); // Fly Drone Button
        buttons[5].SetActive(true); // Start Carousel Button
        buttons[6].SetActive(true); // Stop Carousel Button
        buttons[7].SetActive(true); // Reverse Carousel Direction Button
        buttons[8].SetActive(true); // Carousel Slow Speed
        buttons[9].SetActive(true); // Carousel Medium Speed
        buttons[10].SetActive(true); // Carousel Fast Speed
        buttons[11].SetActive(false); // Teacup Slow Speed
        buttons[12].SetActive(false); // Teacup Medium Speed
        buttons[13].SetActive(false); // Teacup Fast Speed
        buttons[14].SetActive(false); // Tiger Slow Speed
        buttons[15].SetActive(false); // Tiger Medium Speed
        buttons[16].SetActive(false); // Tiger Fast Speed
        buttons[17].SetActive(false); // Teacup Reverse
        buttons[18].SetActive(false); // Car Slow Speed
        buttons[19].SetActive(false); // Car Medium Speed
        buttons[20].SetActive(false); // Car Fast Speed
        buttons[21].SetActive(false); // Drone Slow Speed
        buttons[22].SetActive(false); // Drone Medium Speed
        buttons[23].SetActive(false); // Drone Fast Speed
        buttons[24].SetActive(false); // Car Reverse
    }

    public void TigerButtons()
    {
        buttons[0].SetActive(true); // View Carousel Button
        buttons[1].SetActive(false); // Ride Tiger Button
        buttons[2].SetActive(false); // Ride Teacup Button
        buttons[3].SetActive(false); // Ride Car Button
        buttons[4].SetActive(false); // Fly Drone Button
        buttons[5].SetActive(false); // Start Carousel Button
        buttons[6].SetActive(false); // Stop Carousel Button
        buttons[7].SetActive(false); // Reverse Carousel Direction Button
        buttons[8].SetActive(false); // Carousel Slow Speed
        buttons[9].SetActive(false); // Carousel Medium Speed
        buttons[10].SetActive(false); // Carousel Fast Speed
        buttons[11].SetActive(false); // Teacup Slow Speed
        buttons[12].SetActive(false); // Teacup Medium Speed
        buttons[13].SetActive(false); // Teacup Fast Speed
        buttons[14].SetActive(true); // Tiger Slow Speed
        buttons[15].SetActive(true); // Tiger Medium Speed
        buttons[16].SetActive(true); // Tiger Fast Speed
        buttons[17].SetActive(false); // Teacup Reverse
        buttons[18].SetActive(false); // Car Slow Speed
        buttons[19].SetActive(false); // Car Medium Speed
        buttons[20].SetActive(false); // Car Fast Speed
        buttons[21].SetActive(false); // Drone Slow Speed
        buttons[22].SetActive(false); // Drone Medium Speed
        buttons[23].SetActive(false); // Drone Fast Speed
        buttons[24].SetActive(false); // Car Reverse
    }

    public void TeacupButtons()
    {
        buttons[0].SetActive(true); // View Carousel Button
        buttons[1].SetActive(false); // Ride Tiger Button
        buttons[2].SetActive(false); // Ride Teacup Button
        buttons[3].SetActive(false); // Ride Car Button
        buttons[4].SetActive(false); // Fly Drone Button
        buttons[5].SetActive(false); // Start Carousel Button
        buttons[6].SetActive(false); // Stop Carousel Button
        buttons[7].SetActive(false); // Reverse Carousel Direction Button
        buttons[8].SetActive(false); // Carousel Slow Speed
        buttons[9].SetActive(false); // Carousel Medium Speed
        buttons[10].SetActive(false); // Carousel Fast Speed
        buttons[11].SetActive(true); // Teacup Slow Speed
        buttons[12].SetActive(true); // Teacup Medium Speed
        buttons[13].SetActive(true); // Teacup Fast Speed
        buttons[14].SetActive(false); // Tiger Slow Speed
        buttons[15].SetActive(false); // Tiger Medium Speed
        buttons[16].SetActive(false); // Tiger Fast Speed
        buttons[17].SetActive(true); // Teacup Reverse
        buttons[18].SetActive(false); // Car Slow Speed
        buttons[19].SetActive(false); // Car Medium Speed
        buttons[20].SetActive(false); // Car Fast Speed
        buttons[21].SetActive(false); // Drone Slow Speed
        buttons[22].SetActive(false); // Drone Medium Speed
        buttons[23].SetActive(false); // Drone Fast Speed
        buttons[24].SetActive(false); // Car Reverse
    }

    public void CarButtons()
    {
        buttons[0].SetActive(true); // View Carousel Button
        buttons[1].SetActive(false); // Ride Tiger Button
        buttons[2].SetActive(false); // Ride Teacup Button
        buttons[3].SetActive(false); // Ride Car Button
        buttons[4].SetActive(false); // Fly Drone Button
        buttons[5].SetActive(false); // Start Carousel Button
        buttons[6].SetActive(false); // Stop Carousel Button
        buttons[7].SetActive(false); // Reverse Carousel Direction Button
        buttons[8].SetActive(false); // Carousel Slow Speed
        buttons[9].SetActive(false); // Carousel Medium Speed
        buttons[10].SetActive(false); // Carousel Fast Speed
        buttons[11].SetActive(false); // Teacup Slow Speed
        buttons[12].SetActive(false); // Teacup Medium Speed
        buttons[13].SetActive(false); // Teacup Fast Speed
        buttons[14].SetActive(false); // Tiger Slow Speed
        buttons[15].SetActive(false); // Tiger Medium Speed
        buttons[16].SetActive(false); // Tiger Fast Speed
        buttons[17].SetActive(false); // Teacup Reverse
        buttons[18].SetActive(true); // Car Slow Speed
        buttons[19].SetActive(true); // Car Medium Speed
        buttons[20].SetActive(true); // Car Fast Speed
        buttons[21].SetActive(false); // Drone Slow Speed
        buttons[22].SetActive(false); // Drone Medium Speed
        buttons[23].SetActive(false); // Drone Fast Speed
        buttons[24].SetActive(true); // Car Reverse
    }

    public void DroneButtons()
    {
        buttons[0].SetActive(true); // View Carousel Button
        buttons[1].SetActive(false); // Ride Tiger Button
        buttons[2].SetActive(false); // Ride Teacup Button
        buttons[3].SetActive(false); // Ride Car Button
        buttons[4].SetActive(true); // Fly Drone Button
        buttons[5].SetActive(false); // Start Carousel Button
        buttons[6].SetActive(false); // Stop Carousel Button
        buttons[7].SetActive(false); // Reverse Carousel Direction Button
        buttons[8].SetActive(false); // Carousel Slow Speed
        buttons[9].SetActive(false); // Carousel Medium Speed
        buttons[10].SetActive(false); // Carousel Fast Speed
        buttons[11].SetActive(false); // Teacup Slow Speed
        buttons[12].SetActive(false); // Teacup Medium Speed
        buttons[13].SetActive(false); // Teacup Fast Speed
        buttons[14].SetActive(false); // Tiger Slow Speed
        buttons[15].SetActive(false); // Tiger Medium Speed
        buttons[16].SetActive(false); // Tiger Fast Speed
        buttons[17].SetActive(false); // Teacup Reverse
        buttons[18].SetActive(false); // Car Slow Speed
        buttons[19].SetActive(false); // Car Medium Speed
        buttons[20].SetActive(false); // Car Fast Speed
        buttons[21].SetActive(true); // Drone Slow Speed
        buttons[22].SetActive(true); // Drone Medium Speed
        buttons[23].SetActive(true); // Drone Fast Speed
        buttons[24].SetActive(false); // Car Reverse
    }






    public Camera[] cams;
    public Camera currentcam;

    public void MainCam()
    {
        currentcam = cams[0];
        cams[0].enabled = true;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        MainCameraButtons();
    }

    public void TigerCam()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = false;
        TigerButtons();
    }

    public void TeacupCam()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = true;
        cams[3].enabled = false;
        cams[4].enabled = false;
        TeacupButtons();
    }

    public void CarCam()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = true;
        cams[4].enabled = false;
        CarButtons();
    }

    public void DroneCam()
    {
        cams[0].enabled = false;
        cams[1].enabled = false;
        cams[2].enabled = false;
        cams[3].enabled = false;
        cams[4].enabled = true;
        DroneButtons();
    }


    // Start is called before the first frame update
    void Start()
    {
        MainCam();
        currentcam = cams[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray toMouse = currentcam.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhInfo;
            bool Hit = Physics.Raycast(toMouse, out rhInfo, 500.0f);
            if (Hit)
            {
                if (rhInfo.collider.name == "Tiger")
                {
                    TigerCam();
                    currentcam = cams[1];
                }
                if (rhInfo.collider.name == "Teacup")
                {
                    TeacupCam();
                    currentcam = cams[2];
                }
                if (rhInfo.collider.name == "Car")
                {
                    CarCam();
                    currentcam = cams[3];
                }
                if (rhInfo.collider.name == "Drone")
                {
                    DroneCam();
                    currentcam = cams[4];
                }
                
            }
        }
    }
}
