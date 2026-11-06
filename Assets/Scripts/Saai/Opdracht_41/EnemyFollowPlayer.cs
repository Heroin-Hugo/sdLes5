using UnityEngine;
using UnityEngine.AI;

public class EnemyFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent agent;
    private bool hasKilledPlayer;
    
    private void Update()
    {
        if (hasKilledPlayer) return;
        else agent.SetDestination(player.position);
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("Player") && GameScript.instance.canDie)
        {
            hasKilledPlayer = true;
            agent.SetDestination(transform.position);
            GameScript.instance.KillPlayer();
        }
    }
}
