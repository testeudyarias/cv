namespace tareablazorserver.Data
{
    public class Calculadora
    {
        public decimal Valor1 { get; set; } = 0;
        public decimal Valor2 { get; set; } = 0;
        public string SignoOperacion { get; set; } = string.Empty;
        public decimal Resultado { get {
                if (SignoOperacion == "+")
                {
                    return (decimal)Valor1 + (decimal)Valor2;
                }else if (SignoOperacion == "-")
                {
                    return (decimal)Valor1 - (decimal)Valor2;
                }else if (SignoOperacion == "*")
                {
                    return (decimal)Valor1 * (decimal)Valor2;
                }else if (SignoOperacion == "/")
                {
                    return (decimal)Valor1 / (decimal)Valor2;
                }
                else
                {
                    return 0;
                }
                
            } }
    }
}
