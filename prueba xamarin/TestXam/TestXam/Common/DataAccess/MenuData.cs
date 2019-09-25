using System.Collections.Generic;
using TestXam.Common.DTO;

namespace TestXam.Common.DataAccess
{
    public class MenuData
    {
        private List<MenuDTO> _data = new List<MenuDTO>
            {
                new MenuDTO { Page = new ContentIndex(), MenuTitle = "Inicio", MenuDetail = "Inicio", Icon="home.png"},
                new MenuDTO { Page = null, MenuTitle = "Logout", MenuDetail = "Cerrar sesion", Icon= "lock.png"}
            };

        public List<MenuDTO> GetMenu()
        {
            return _data;
        }
    }
}
