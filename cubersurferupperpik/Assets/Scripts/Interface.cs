public interface ICollectable 
{
    void Collect();    
}

public interface IDecreaseable
{
    void Decreas();
}

public interface IFinishable
{
    void GameFinish();
}

public interface ICoinable
{
    void Coins();
}

public interface IGameOverable
{
    void Over();
}