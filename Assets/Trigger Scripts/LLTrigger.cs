using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLTrigger : MonoBehaviour
{
    //This is Main Camera in the Scene
    Camera m_MainCamera;

    //public Camera m_CameraTwo;

    public Camera m_UHallCamera;
    public Camera m_LHallCamera;
    public Camera m_LLCamera;
    public Camera m_MRCamera;
    public Camera m_MLCamera;
    public Camera m_ULCamera;
    public Camera m_URCamera;
    /*
     Camera m_U.HallCamera
     Camera m_L.HallCamera
     Camera m_L.LCamera
     Camera m_M.RCamera
     Camera m_M.LCamera
     Camera m_U.LCamera
     Camera m_U.RCamera
     * 
     * 
     * */
    void Start()
    {
        //This gets the Main Camera from the Scene
        m_MainCamera = Camera.main;
        //This enables Main Camera
        m_MainCamera.enabled = true;
        //Use this to disable secondary Camera
        m_UHallCamera.enabled = false;
        m_LHallCamera.enabled = false;
        //Use this to disable third camera 
        m_LLCamera.enabled = false;
        m_MRCamera.enabled = false;
        m_MLCamera.enabled = false;
        m_ULCamera.enabled = false;
        m_URCamera.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        //Press the L Button to switch cameras
        if (other.tag == "Player")
        {
            m_MainCamera.enabled = false;
            m_UHallCamera.enabled = false;
            m_LHallCamera.enabled = false;
            m_LLCamera.enabled = true;
            m_MRCamera.enabled = false;
            m_MLCamera.enabled = false;
            m_ULCamera.enabled = false;
            m_URCamera.enabled = false;

        }
    }
    /*void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            m_MainCamera.enabled = false;
            m_UHallCamera.enabled = false;
            m_LHallCamera.enabled = true;
            m_LLCamera.enabled = false;
            m_MRCamera.enabled = false;
            m_MLCamera.enabled = false;
            m_ULCamera.enabled = false;
            m_URCamera.enabled = true;

        }
    }
    */
}
