using SistemaNotas.views;

namespace SistemaNotas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculadora();
        }
    }
}
