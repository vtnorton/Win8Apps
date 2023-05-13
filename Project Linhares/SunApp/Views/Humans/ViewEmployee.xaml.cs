using SunApp.AddEmployee;
using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SunApp.Views.Humans
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ViewEmployee : Page
    {
        private add_employeeSoapClient x = new add_employeeSoapClient();
        public ViewEmployee()
        {
            this.InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            spvEmployeee.IsPaneOpen = !spvEmployeee.IsPaneOpen;
            //Frame.Navigate(typeof(AddEmployee));
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            spvEmployeee.IsPaneOpen = !spvEmployeee.IsPaneOpen;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool temp;
                if (ckbIsTemp.IsChecked == true)
                    temp = true;
                else
                    temp = false;

                x.AddEmployeeAsync(1, txtName.Text, txtLastName.Text, txtNickname.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text, "30/03", temp, 1, "0", "0", "0", txtCPF.Text, txtRG.Text, " ", txtCarteiraDeTrabalho.Text, txtCNPJ.Text);
                spvEmployeee.IsPaneOpen = !spvEmployeee.IsPaneOpen;
                txtAddress.Text = "";
                txtCarteiraDeTrabalho.Text = "";
                txtCNPJ.Text = "";
                txtCPF.Text = "";
                txtEmail.Text = "";
                txtLastName.Text = "";
                txtName.Text = "";
                txtNickname.Text = "";
                txtPhone.Text = "";
                txtRG.Text = "";
                grdInfo.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                Erro(ex);
            }
            
        }
        private async void Erro(Exception Ex)
        {
            MessageDialog dialogo = new MessageDialog("Erro ao inserir funcionário: " + Ex.Message);
            await dialogo.ShowAsync();
        }
        private void tgtPersonType_Toggled(object sender, RoutedEventArgs e)
        {
            if (tgtPersonType.IsOn == true)
            {
                txtCNPJ.Visibility = Visibility.Visible;
                txtCPF.Visibility = Visibility.Collapsed;
                txtCarteiraDeTrabalho.Visibility = Visibility.Collapsed;
                txtRG.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtCNPJ.Visibility = Visibility.Collapsed;
                txtCPF.Visibility = Visibility.Visible;
                txtCarteiraDeTrabalho.Visibility = Visibility.Visible;
                txtRG.Visibility = Visibility.Visible;
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            grdInfo.Visibility = Visibility.Collapsed;
        }
    }
}
