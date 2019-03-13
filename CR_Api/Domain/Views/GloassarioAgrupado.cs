using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Views
{
    public class GloassarioAgrupado
    {
        public char Letra { get; set; }
        public List<Glossario> Palavras { get; set; }
    }
}
