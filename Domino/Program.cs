class Domino
{
    public int l1;
    public int l2;
    public Domino (int L1,int L2)
    {
        L1=l1;
        L2=l2;
    }
    public void Dominoes (int d1, int d2)
    {
        this.l1=d1;
        this.l2=d2;
    }
    public static Domino operator +(Domino a, Domino b)
    {
        int total=a.l1+a.l2+b.l1+b.l2;
    }
}



internal class Program
{
    private static void Main(string[] args)
    {
        Domino d1= new Domino (1,1);
        Domino d2= new Domino (2,2);
        int total=d1+d2;
    }
}