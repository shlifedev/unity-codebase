namespace LD.StateMachine
{
    public abstract class Transition<TStateKey, TState>
        where TState : State<TStateKey>
    {
        private StateMachine _rootStateMachine;

        public Transition(StateMachine rootStateMachine)
        {
            _rootStateMachine = rootStateMachine;
        } 
        
        public void CheckTransition()
        {
            if (CanTransition())
            {
                // do transition
            }
            else
            {
                
            }
        }

        protected abstract bool CanTransition();
    }
}