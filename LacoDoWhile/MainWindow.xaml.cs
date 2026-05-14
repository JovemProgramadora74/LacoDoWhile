using System.Windows;
using System.Windows.Input;

namespace LacoDoWhile;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        tbNumeroEscolhido.Focus();
    }

    private void ComecarSortear(object sender, RoutedEventArgs e)
    {
        var numeroDigitado = tbNumeroEscolhido.Text;

        int numeroDigitadoConvertido;
        try
        {
            numeroDigitadoConvertido = Convert.ToInt32(numeroDigitado);
        }
        catch (FormatException)
        {
            MessageBox.Show("Entrada invalida! Digite apenas números.");
            return;
        }
        catch (OverflowException)
        {
            MessageBox.Show("Numero digitado é maior que o suportado!");
            return;
        }

        if (numeroDigitadoConvertido < 0 || numeroDigitadoConvertido > 10)
        {
            MessageBox.Show("O número digitado tem que ser entre 0 e 10.", "Erro!");
            return;
        }

        int numeroEscolhidoMaquina;
        var sorteador = new Random();
        var contador = 0;

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