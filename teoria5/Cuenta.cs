using System.Data;
using System.Numerics;

namespace teoria5;
public class Cuenta{

    public int Saldo { get; set; }
    static int cuentasCreadas{ get; set; } = 0;
    static int operacionesDenegadas { get; set; } = 0;

    static int saldoDepositado { get; set; } = 0;

    static int saldoExtraido { get; set; } = 0;

    static int depositos { get; set; } = 0;

    static int extracciones { get; set; } = 0;

    public static List<Cuenta> cuentas 
    
    {
        get => new List<Cuenta>(s_cuentas);
    }

    private static List<Cuenta>s_cuentas = new List<Cuenta>();

    int nroCuenta{ get; set; }
    public Cuenta(){
        cuentasCreadas++;
        nroCuenta = cuentasCreadas;
        s_cuentas.Add(this);
        Console.WriteLine("Se creó la cuenta Id = " + nroCuenta);
    
    }

    public Cuenta Depositar(int monto){
        Saldo += monto;
        Console.WriteLine($"Se depositó {monto} en la cuenta {nroCuenta} (Saldo = {Saldo})");
        depositos++;
        saldoDepositado += monto;
        return this;
    }

    public Cuenta Extraer(int monto){
        if (Saldo < monto)
        {
            Console.WriteLine("Operación denegada - Saldo insuficiente");
            operacionesDenegadas++;
        }
        else 
        {
            extracciones++;
            saldoExtraido += monto;
            Saldo -= monto;
            Console.WriteLine($"Se extrajo {monto} de la cuenta {nroCuenta} (Saldo = {Saldo})");
        }
        return this;
    }

    public static void ImprimirDetalle (){
        Console.WriteLine($"{"CUENTAS CREADAS:", -20}{cuentasCreadas}");
        Console.WriteLine($"{"DEPOSITOS:", -19} {depositos} - {"Total depositado:", -20}{saldoDepositado}");
        Console.WriteLine($"{"EXTRACCIONES:",-20}{extracciones} - {"Total extraido:", -20}{saldoExtraido}");
        Console.WriteLine($"{"", -21} - Saldo: {saldoDepositado - saldoExtraido}");
        Console.WriteLine($" * Se denegaron {operacionesDenegadas} por falta de fondos");
    }


}