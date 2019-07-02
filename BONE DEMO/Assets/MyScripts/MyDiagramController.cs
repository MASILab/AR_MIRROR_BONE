using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDiagramController : MonoBehaviour {
    

    public GameObject BN_Left_Forearm;
    public GameObject BN_Right_Forearm;
    public GameObject BN_ShoulderSpine_MidSpine;
    public GameObject BN_MidSpine_BaseSpine;
    public GameObject BN_Left_Hip;
    public GameObject BN_Right_Hip;
    public GameObject BN_Left_UpperLeg;
    public GameObject BN_Right_UpperLeg;
    public GameObject BN_Left_LowerLeg;
    public GameObject BN_Right_LowerLeg;

	
	//Update is called once per frame
	void Update () {
        updateBoneDiagrams();
	}

    private void updateBoneDiagrams()
    {
        switch (MySkeletonRenderer.selectedBoneName)
        {
            case "LeftElbow_LeftWrist":
                display(BN_Left_Forearm);
                break;
            case "RightElbow_RightWrist":
                display(BN_Right_Forearm);
                break;
            case "MidSpine_ShoulderSpine":
                display(BN_ShoulderSpine_MidSpine);
                break;
            case "BaseSpine_MidSpine":
                display(BN_MidSpine_BaseSpine);
                break;
            case "BaseSpine_LeftHip":
                display(BN_Left_Hip);
                break;
            case "BaseSpine_RightHip":
                display(BN_Right_Hip);
                break;
            case "LeftHip_LeftKnee":
                display(BN_Left_UpperLeg);
                break;
            case "LeftKnee_LeftFoot":
                display(BN_Left_LowerLeg);
                break;
            case "RightHip_RightKnee":
                display(BN_Right_UpperLeg);
                break;
            case "RightKnee_RightFoot":
                display(BN_Right_LowerLeg);
                break;
            default:
                display(null);
                break;
        }
    }

    private void display(GameObject gameObject)
    {
        //Deactivate all other diagrams
        hideAllBones();

        if (gameObject != null)
        {
            gameObject.SetActive(true);
            //Debug.Log(gameObject.name);
        }
    }

    private void hideAllBones()
    {
        BN_Left_Forearm.SetActive(false);
        BN_Right_Forearm.SetActive(false);
        BN_ShoulderSpine_MidSpine.SetActive(false);
        BN_MidSpine_BaseSpine.SetActive(false);
        BN_Left_Hip.SetActive(false);
        BN_Right_Hip.SetActive(false);
        BN_Left_UpperLeg.SetActive(false);
        BN_Right_UpperLeg.SetActive(false);
        BN_Left_LowerLeg.SetActive(false);
        BN_Right_LowerLeg.SetActive(false);
    }
}
