class Area
{
    public static float Quad(float bas, float alt)
    {
        if (bas == 0 || alt == 0)
        {
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * alt;
    }
}
class Aula52
{
    static void Main()
    {
        try
        {
            float area = Area.Quad(0F, 5F);
            Console.WriteLine("Area do quad.:{0}", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERRO:{0}", e.Message);
            Console.WriteLine("Ex:{0}", e.GetType());
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }
    }
}