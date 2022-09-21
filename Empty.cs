public class Empty : Piece
{
    int posititon;

    public Empty(int posititon)
    {
        this.posititon = posititon;
    }

    public override string Print()
    {
        return posititon.ToString();
    }
}