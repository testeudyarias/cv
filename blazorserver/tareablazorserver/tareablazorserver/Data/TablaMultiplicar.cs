namespace tareablazorserver.Data
{
    public class TablaMultiplicar
    {
        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
            set { 
                _Numero = value;
                Calcular();
            }
        }
        private int _Tope= 12;

        public int Tope
        {
            get { return _Tope; }
            set { _Tope = value; Calcular();  }
        }


        public List<TablaMultiplicarDetalle> Detalle { get; set; } = new ();
        public void Calcular() {
            Detalle.Clear();
            for (int i = 0; i <= Tope; i++)
            {
                Detalle.Add(new TablaMultiplicarDetalle
                {
                    Multiplicador = _Numero,
                    Multiplicando = i,
                    Producto = (i * _Numero)
                });
            }
        }
    }
    public class TablaMultiplicarDetalle { 
        public int Multiplicando { get; set;} = 0;
        public int Multiplicador { get; set;} = 0;
        /// <summary>
        /// Resultado
        /// </summary>
        public int Producto { get; set; } = 0;
    } 
}
