using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class DadosConexao
{
    public static string StringDeConexao
    {
        get
        {
            return "Host=localhost;Port=5432;Database=Semente;Username=postgres;Password=1234;";
        }
    }
}