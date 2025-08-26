namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");
        public MainPage()
        {
            InitializeComponent();
            if(File.Exists(caminho))
            editor.Text = File.ReadAllText(caminho);
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
            DisplayAlert("Arquivo salvo",$"Arquivo {Path.GetFileName(caminho)} salvo com sucesso na pasta {caminho}","OK" );
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
            editor.Text = String.Empty; // ou editor.Text = String.Empty

            if (File.Exists(caminho))
            {
                File.Delete(caminho);
                DisplayAlert("Arquivo Apagado", "Arquivo Apagado com Sucesso", "OK");
            }
            else
            {
                DisplayAlert("Falhou", "Arquivo inexistente ou texto apagado", "OK");
            }
        }
    }

}
