
using UnityEngine;

public class VirusAnimation : MonoBehaviour
{
    float m_defaultScale;

    float m_Iteration = 1f;
    [SerializeField]float m_AnimationSpeed = 4.0f;    
    [SerializeField] float m_ScaleDelta = 0.01f;

    [SerializeField] float m_ScalePhase = 1.0f;
    Vector3 m_RotationDirection = Vector3.one;

    // Start is called before the first frame update
    void Start()
    {
        float rotationX = Random.Range(-100, 100) / (1 / m_AnimationSpeed);
        float rotationY = Random.Range(-100, 100) / (1 / m_AnimationSpeed);
        float rotationZ = Random.Range(-100, 100) / (1 / m_AnimationSpeed);
        m_RotationDirection = new Vector3(rotationX, rotationY, rotationZ);

        m_ScalePhase = Random.Range(-100, 100);
        m_defaultScale = ((this.transform.localScale.x + this.transform.localScale.y + this.transform.localScale.z) / 3);
    }


    private void FixedUpdate()
    {
        m_Iteration += (m_AnimationSpeed * Time.deltaTime);
        AdjustScale();
        AdjustRotation();
    }
    private void AdjustRotation()
    {
        float newRotationX = this.transform.localRotation.x + m_RotationDirection.x + m_Iteration * m_AnimationSpeed;
        float newRotationY = this.transform.localRotation.y + m_RotationDirection.y + m_Iteration * m_AnimationSpeed;
        float newRotationZ = this.transform.localRotation.z + m_RotationDirection.z + m_Iteration * m_AnimationSpeed;
        this.transform.localRotation = Quaternion.Euler(newRotationX, newRotationY, newRotationZ);        
    }
    private void AdjustScale()
    {
        float Scale = m_ScaleDelta * Mathf.Sin(m_Iteration + m_ScalePhase);
        this.transform.localScale = Vector3.one * (Scale + 1);
    }
}
