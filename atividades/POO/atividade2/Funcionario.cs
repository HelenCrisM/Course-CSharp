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

    public double AumentarSalario(double porcentagem) 
    {
      double aumentoSalario = SalarioLiquido() + (SalarioBruto * (porcentagem/100));
      return aumentoSalario;
    }
}