using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EEEMC_SANTATERESINHA
{
    /// <summary>
    /// Lógica interna para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastrarEscola tela = new CadastrarEscola();
            this.Close();
            tela.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CadastrarAluno tela = new CadastrarAluno();
            this.Close();
            tela.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CadastrarCurso tela = new CadastrarCurso();
            this.Close();
            tela.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CadastrarTurma tela = new CadastrarTurma();
            this.Close();
            tela.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Dados tela = new Dados();
            this.Close();
            tela.Show();
        }
    }
}
