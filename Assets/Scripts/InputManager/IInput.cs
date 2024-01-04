public interface IInput
{
    DIRECTION GetInput();
}

public enum DIRECTION
{
    LEFT,
    RIGHT,
    JUMP,
    NONE
}