using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMenuServices
    {
        public List<MenuDetailsResponse> GetMenuItems();

        public MenuDetailsRequest PostMenuItems();

        public MenuDetailsRequest UpdateMenuItems();

        public void DeleteMenuDetails();
    }

}
