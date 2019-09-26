using System;
using System.Collections.Generic;
using System.Text;
using TestXam.Common.DTO;

namespace TestXam.Common.DataAccess
{
    public class PaisData
    {
        private List<PaisDTO> _data = new List<PaisDTO>
        {
            new PaisDTO { Id=0, Description="Random"},
            new PaisDTO { Id=1, Description="Todos", Pictures = new List<string>{ "Espana1.jpg", "Espana2.jpg", "Francia1.jpg", "Francia2.jpg", "Argentina1.jpg", "Argentina2.jpg", "Brasil1.jpg", "Brasil2.jpg", "EEUU1.jpg", "EEUU2.jpg", "Mexico1.jpg", "Mexico2.jpg" } },
            new PaisDTO { Id=2, Description="España", Pictures = new List<string>{"Espana1.jpg","Espana2.jpg"}},
            new PaisDTO { Id=3, Description="Francia", Pictures = new List<string>{"Francia1.jpg","Francia2.jpg"}},
            new PaisDTO { Id=4, Description="Argentina", Pictures = new List<string>{"Argentina1.jpg","Argentina2.jpg"}},
            new PaisDTO { Id=5, Description="Brasil", Pictures = new List<string>{"Brasil1.jpg","Brasil2.jpg"}},
            new PaisDTO { Id=6, Description="EEUU", Pictures = new List<string>{"EEUU1.jpg","EEUU2.jpg"}},
            new PaisDTO { Id=7, Description="Mexico", Pictures = new List<string>{"Mexico1.jpg","Mexico2.jpg"}},
        };

        public List<PaisDTO> GetPaises()
        {
            return _data;
        }
    }
}
