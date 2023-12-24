using UnityEngine;

namespace LD.StateMachine
{

    public interface IStateMachineProvider
    {
        public IStateMachineProvider Object { get; }
        public void doStuff();
    }

    public class StateMachineTaskManager : MonoBehaviour, IStateMachineProvider
    {
        public static void Initialize()
        {

        }

        public IStateMachineProvider Object { get; }

        public void doStuff()
        {
            throw new System.NotImplementedException();
        }
    }

    public class StateMachineProxy : IStateMachineProvider
    {
        public IStateMachineProvider Object { get; }

        public void doStuff()
        {
            throw new System.NotImplementedException();
        }
    }
}