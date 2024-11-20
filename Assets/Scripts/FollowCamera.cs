using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target; // ���� ��� (ĳ����)
    public Vector3 offset = new Vector3(0, 10, -10); // ĳ���Ϳ��� ���� �Ÿ�

    private Vector3 fixedRotation; // ������ ī�޶� ����

    void Start()
    {
        // �ʱ� ī�޶��� ȸ������ ����
        fixedRotation = transform.eulerAngles;
    }

    void LateUpdate()
    {
        if (target != null)
        {
            // ĳ������ ��ġ�� offset��ŭ �̵�
            transform.position = target.position + offset;

            // ī�޶��� ������ �ʱⰪ���� ����
            transform.rotation = Quaternion.Euler(fixedRotation);
        }
    }
}
