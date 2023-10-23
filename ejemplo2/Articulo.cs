using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        //-Codigo Articulo (3 digitos no correlativos)
        //Precio
        //-Codigo de Marca

        // puedo omitir la creacio de la variable privada (private int codArticulo) para manipular desde el exterior, directamente
        // creando la propiedad del codArticulo. Para esto escribo prop (tab tab); Con este formato no puedo mànipular el getter
        //y el setter
        public int CodArticulo { get; set; }
        public int Precio { get; set; }

        //a este sì le puedo manipular el getter y el setter
        private int CodMarca;
        public int CodMarca
        {
            get { return CodMarca; }
            set 
            {
                if (value > 0 && value < 11)
                    CodMarca = value;
                else
                    CodMarca = -1;

            } 
        }


    }
}
