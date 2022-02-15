using System;

public abstract class BaseHealthPresenter : BasePresenter<IHealthView>
{
    public virtual event Action OnDeathEvent;
    public BaseHealthPresenter(IHealthView view) : base(view)
    {
    }
    
    public abstract void InitModel(int currentHealth, int maxHealth);
    public abstract void Heal(int value);
    public abstract void TakeDamage(int value);
}