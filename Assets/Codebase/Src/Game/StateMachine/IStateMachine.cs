using System.Collections.Generic;

namespace LD.StateMachine;

public interface IStateMachine<TStateKey>
{
    public void ChangeState(bool checkTransitionCondition)
    {
        
    }

    /// <summary>
    /// 상태머신을 초기화합니다.
    /// </summary>
    /// <param name="initalizeStateKey">상태머신에 등록된 키를 입력해주세요.</param>
    public void Initialize(List<State<TStateKey>> list, TStateKey initalizeStateKey)
    {
        
    }
}