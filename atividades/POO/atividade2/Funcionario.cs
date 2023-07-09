class Funcionario 
{
  public string Nome;
  public double SalarioBruto;
  public double Imposto;

    public double SalarioLiquido() 
    {
      double salarioLiquido = SalarioBruto - Imposto;
      return salarioLiquido;
    }

    // public void AumentarSalario(double porcentagem) 
    // {
    //   return SalarioLiquido() + (porcentagem/100)
    // }
}