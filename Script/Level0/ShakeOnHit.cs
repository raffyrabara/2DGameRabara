using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ShakeOnHit : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vCamera;
    [SerializeField] float apli, frequen, shakeTime;
    // Start is called before the first frame update


public IEnumerator StartShake()
{
    vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = apli;
    vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequen;
    yield return new WaitForSeconds(shakeTime);
    vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
    vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
}

}