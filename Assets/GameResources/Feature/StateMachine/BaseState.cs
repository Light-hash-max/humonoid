using UnityEngine;

/// <summary>
/// �������� ���������
/// </summary>
public abstract class BaseState
{
    protected Animator _animator = default;

    /// <summary>
    /// ���� � ���������
    /// </summary>
    /// <param name="sparrow"></param>
    public virtual void EnterState(StateManager stateManager) => _animator = stateManager.Animator;
}
