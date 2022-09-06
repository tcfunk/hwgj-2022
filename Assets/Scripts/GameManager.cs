using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager m_Singleton;
    public static GameManager Singleteon { get => m_Singleton; }
    
    private void Awake()
    {
        if (m_Singleton != null && m_Singleton != this) Destroy(this.gameObject);
        m_Singleton = this;
    }
}
