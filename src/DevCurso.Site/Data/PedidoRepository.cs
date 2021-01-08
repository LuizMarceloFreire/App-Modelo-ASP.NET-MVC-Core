using DevCurso.Site.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCurso.Site.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }

    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
