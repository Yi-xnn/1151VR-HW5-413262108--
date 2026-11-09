using UnityEngine;
using UnityEngine.InputSystem;

public class TrainerThrow : MonoBehaviour
{
    [Header("請把下方的 精靈球 Prefab 拖進來")]
    public GameObject pokeBallPrefab;

    [Header("丟球的起點 (請把訓練家自己拖進來)")]
    public Transform throwPoint;

    [Header("拋物線力道 (X軸往右, Y軸往上)")]
    public float forwardForce = 1200f;
    public float upwardForce = 400f;

    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            GameObject ball = Instantiate(pokeBallPrefab, throwPoint.position, Quaternion.Euler(90f, 90f, -90f));

            Vector3 throwDirection = new Vector3(1, 0, 0) * forwardForce + new Vector3(0, 1, 0) * upwardForce;

            ball.GetComponent<Rigidbody>().AddForce(throwDirection);
        }
    }
}