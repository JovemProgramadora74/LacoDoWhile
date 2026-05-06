using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LacoDoWhile;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        tbNumeroEscolhido.Focus();
    }

    private void ComecarSortear(object sender, RoutedEventArgs e)
    {
        string numeroDigitado = tbNumeroEscolhido.Text;
        int numeroDigitadoConvertido = Convert.ToInt32(numeroDigitado);

        if (numeroDigitadoConvertido < 0 || numeroDigitadoConvertido > 10)
        {
            MessageBox.Show("O número digitado tem que ser entre 0 e 10.", "Erro!");
            return;
        }

        int numeroEscolhidoMaquina;
        var sorteador = new Random();
        int contador = 0;

        do
        {
            numeroEscolhidoMaquina = sorteador.Next(0, 11);
            MessageBox.Show(
                $"O usuário escolheu {numeroDigitadoConvertido} e a máquina escolheu {numeroEscolhidoMaquina}");
            contador++;
        } while (numeroEscolhidoMaquina != numeroDigitadoConvertido);

        MessageBox.Show($"O computador sorteou {contador} vezes");
    }

    private void QuandoEnterPressionado(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            ComecarSortear(sender, e);
        }
    }
}