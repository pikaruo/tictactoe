class TicTacToe
{
    static void Main()
    {
        // inisiasi player dan board
        Player X = new Player('X');
        Player Y = new Player('O');
        Empty E = new Empty(0);

        //? Console.WriteLine(X is Piece);
        //? Console.WriteLine(Y is Piece);
        //? Console.WriteLine(E is Piece);
        //? Console.WriteLine(X.Print());
        //? Console.WriteLine(Y.Print());
        //? Console.WriteLine(E.Print());

        PrintValue(X);
        PrintValue(Y);
        PrintValue(E);

        // Pilih player yang mulai duluan

        // active player pilih posisi

        //  active player taro piece

        // cek apakah ada pemenang

        // jika iya game over; kalau tidak ganti player dan ulangi ke pilih posisi
    }

    static void PrintValue(Piece piece)
    {
        Console.WriteLine(piece.Print());
    }
}