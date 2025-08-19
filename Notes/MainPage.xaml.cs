namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");
        public MainPage()
        {
            InitializeComponent();
        }

        private void editor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void editor_Completed(object sender, EventArgs e)
        {

        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
            string conteudo = editor.Text;
            File.WriteAllText(caminho, conteudo);
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {

        }
    }

}
