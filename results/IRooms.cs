public interface IRoom
{
    string Type { get; }
    string Name { get; }
    bool Enter();
}