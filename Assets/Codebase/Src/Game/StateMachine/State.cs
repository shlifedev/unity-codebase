namespace LD.StateMachine
{
    public class State<TStateKey>
    {
        public State(TStateKey key)
        {
            this.Key = key;
        }

        public TStateKey Key { get; set; }

        public void OnStateEnter()
        {

        }

        public void OnStateUpdate()
        {

        }

        public void OnStateExit()
        {

        }
    }
}