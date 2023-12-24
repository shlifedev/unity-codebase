using System.Collections.Generic;

namespace LD.StateMachine
{
    public sealed class StateMachine : IStateMachine<string>
    {
        public StateMachine()
        {
            
        }

        public void ChangeState(bool checkTransitionCondition)
        {
            throw new System.NotImplementedException();
        }

        public void Initialize(List<State<string>> list, string initalizeStateKey)
        {
            throw new System.NotImplementedException();
        }
    }
}