using System;

class Program
{
    static void Main(string[] args)
    {
        Teste.Calculo();
    }
}


public class Var
{
    public double Valor;
    public double Taxa;
    public int mes;
    public int dia;
    public double periodo;
    public double calculo;
    public string valorverificar;
    public double valordoresgate;
    public int valorsemresgate = 0;
    public int mesresgate;

}
public class Teste
{
    public static void Calculo()
    {

        Var valor = new Var();
        Console.WriteLine("Digite o valor investido:");
        valor.Valor = Convert.ToDouble(Console.ReadLine());

        Var taxa = new Var();
        Console.WriteLine("Digite a taxa de juros");
        taxa.Taxa = Convert.ToDouble(Console.ReadLine());

        Var meses = new Var();
        Console.WriteLine("Digite o mês: ");
        meses.mes = Convert.ToInt32(Console.ReadLine());

        Var dias = new Var();
        Console.WriteLine("Digite os dias");
        dias.dia = Convert.ToInt32(Console.ReadLine());

        Var periodos = new Var();
        periodos.periodo = meses.mes + (dias.dia / 30.0);

        //F = p * (1+i) ^n

        Var calculos = new Var();
        calculos.calculo = valor.Valor * Math.Pow(1 + taxa.Taxa / 100, periodos.periodo);


        Var resgate = new Var();
        Console.WriteLine("Gostaria de resgatar algum valor?");
        resgate.valorverificar = Console.ReadLine();



        if(resgate.valorverificar == "sim")
        {

            Console.WriteLine("Qual valor que gostaria de resgatar?");
            resgate.valordoresgate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Em qual mês?");
            resgate.mesresgate = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Aqui está sua tabela");
            Console.WriteLine("[---------------------------------------------------------------------------------------------------------------]");
            Console.WriteLine($"[Valor investido:{valor.Valor:C}");
            Console.WriteLine("[---------------------------------------------------------------------------------------------------------------]");
            Console.WriteLine($"[Valor calculado sem o resgate:{calculos.calculo:C}");
            Console.WriteLine("[---------------------------------------------------------------------------------------------------------------]");
            Console.WriteLine($"[Valor que foi resgatado:{resgate.valordoresgate:C}");
            Console.WriteLine("[----------------------------------------------------------------------------------------------------------------]");
            Console.WriteLine($"[Valor com o resgate efetuado no {resgate.mesresgate} mêS foi: {calculos.calculo - resgate.valordoresgate:C}");
            Console.WriteLine("[---------------------------------------------------------------------------------------------------------------]");


        }
        if (resgate.valorverificar == "nao")
        {
            resgate.valorsemresgate =  0;
            Console.WriteLine("Aqui está sua tabela");
            Console.WriteLine("[-----------------------------------]");
            Console.WriteLine($"[Valor investido:{valor.Valor:C}");
            Console.WriteLine("[-----------------------------------]");
            Console.WriteLine($"[Valor calculado :{calculos.calculo:C}]");
            Console.WriteLine("[-----------------------------------]");
            Console.WriteLine($"[Nenhum valor foi resgatado: {resgate.valorsemresgate:C}");

        }





    }
}