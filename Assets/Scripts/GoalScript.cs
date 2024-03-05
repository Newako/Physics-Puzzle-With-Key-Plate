using UnityEngine;
using UnityEngine.Events;
public class GoalScript : MonoBehaviour
{

    [SerializeField] GameObject key;

    public UnityEvent onUnlock;
    public void UnlockEventTriggered()
    {
        onUnlock.Invoke();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            UnlockEventTriggered();
        }
    }
    public void TestUnlock()
    {
        Debug.Log("GOAL!");
    }
}