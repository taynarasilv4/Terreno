public class Terreno
{
    private double largura;
    private double comprimento;

    public Terreno(double largura, double comprimento)
    {
        this.largura = largura;
        this.comprimento = comprimento;
    }

    public double Area()
    {
        return largura * comprimento;
    }

    public double Valor(double valorMetroQuadrado)
    {
        return valorMetroQuadrado * Area();
    }

    public double GetLargura()
    {
       return this.largura; 
    }

    public void SetLargura(double Largura)
    {
        this.largura = Largura;
    }
    public double GetComprimento()
    {
        return this.comprimento;
    }

    public void SetComprimento(double Comprimento)
    {
        this.comprimento = Comprimento;
    }
   
}
