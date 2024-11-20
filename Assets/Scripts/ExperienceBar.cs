using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    public Image experienceFill; // ExperienceBarFill ����
    private float currentExperience = 0f;
    private float maxExperience = 100f;

    void Update()
    {
        // ����ġ �� ������Ʈ (�ӽ÷� �׽�Ʈ�� ����ġ ���� �ڵ�)
        if (currentExperience < maxExperience)
        {
            currentExperience += Time.deltaTime * 10; // ����ġ ���� �ӵ�
            UpdateExperienceBar();
        }
    }

    public void UpdateExperienceBar()
    {
        float fillAmount = currentExperience / maxExperience;
        experienceFill.fillAmount = fillAmount;
    }

    public void AddExperience(float amount)
    {
        currentExperience = Mathf.Clamp(currentExperience + amount, 0, maxExperience);
        UpdateExperienceBar();
    }
}
