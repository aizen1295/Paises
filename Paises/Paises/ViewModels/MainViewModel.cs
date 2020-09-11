namespace Paises.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public PaisesViewModel Paises
        { 
            get; 
            set; 
        }
        #endregion

        #region Constructors

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }

        #endregion
    }
}
