using Application.Dto;
using System.Collections.Generic;

namespace Application.Views
{
    public class GloassarioAgrupadoDto
    {
        public char Letra { get; set; }
        public List<GlossarioDto> Palavras { get; set; }

        public GloassarioAgrupadoDto()
        {

        }
    }
}
