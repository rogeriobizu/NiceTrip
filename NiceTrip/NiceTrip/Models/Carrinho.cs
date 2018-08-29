using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NiceTrip.Models
{
    public class Carrinho
    {
        IList<Item> Itens { get; set; }
    }
}