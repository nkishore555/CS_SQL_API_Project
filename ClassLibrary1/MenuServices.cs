using Application.Interfaces;

namespace ClassLibrary1
{
    public class MenuServices : IMenuServices
    {
        public void DeleteMenuDetails()
        {
            throw new NotImplementedException();
        }

        public List< MenuDetailsResponse> GetMenuItems()
        {
            // Dummy data for demonstration purposes
            return new List<MenuDetailsResponse>
            {
                new MenuDetailsResponse { id = 1, name = "Pizza" },
                new MenuDetailsResponse { id = 2, name = "Burger" },
                new MenuDetailsResponse { id = 3, name = "Pasta" }
            };
        }

        public MenuDetailsRequest PostMenuItems()
        {
            throw new NotImplementedException();
        }

        public MenuDetailsRequest UpdateMenuItems()
        {
            throw new NotImplementedException();
        }
    }
}
