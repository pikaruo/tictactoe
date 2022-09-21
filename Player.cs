public class Player : Piece
{
    char symbol;

    public Player(char symbol)
    {
        this.symbol = symbol;
    }

    public override string Print()
    {
        return symbol.ToString();
    }
}