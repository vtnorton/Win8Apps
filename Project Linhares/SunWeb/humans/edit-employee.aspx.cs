using SunCore.Methods;
using SunCore.Repository;
using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace SunWeb.humans
{
    public partial class edit_employee : System.Web.UI.Page
    {
        public int IdUser = 1;
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = int.Parse(Request.QueryString["Id"]);
            EmployeeRepository repoEmployee = new EmployeeRepository();
            DocumentRepository repoDocument = new DocumentRepository();
            int IdDocument = repoEmployee.RetornarID(Id).IdDocument;

            txtAddress.Text = repoEmployee.RetornarID(Id).Address;
            txtBirtday.Text = repoEmployee.RetornarID(Id).Birthday;
            txtBrazilCDTCadastro.Text = repoDocument.RetornarID(IdDocument).BrazilCDTCadastro;
            txtBrazilCDTEmitionDate.Text = repoDocument.RetornarID(IdDocument).BrazilCDTDataDeEmissao;
            txtBrazilCDTNumber.Text = repoDocument.RetornarID(IdDocument).BrazilCDTNumero;
            txtBrazilCDTPIS.Text = repoDocument.RetornarID(IdDocument).BrazilCDTPIS;
            txtBrazilCDTSerie.Text = repoDocument.RetornarID(IdDocument).BrazilCDTSerie;
            txtBrazilCDTSigla.Text = repoDocument.RetornarID(IdDocument).BrazilCDTSigla;
            txtBrazilCNH.Text = repoDocument.RetornarID(IdDocument).BrazilCNH;
            txtBrazilCPF.Text = repoDocument.RetornarID(IdDocument).BrazilCPF;
            txtBrazilRG.Text = repoDocument.RetornarID(IdDocument).BrazilRG;
            txtCity.Text = repoEmployee.RetornarID(Id).City;
            txtDaysAtWork.Text = repoEmployee.RetornarID(Id).DayOfWork;
            txtFirstName.Text = repoEmployee.RetornarID(Id).Name;
            txtHiringDate.Text = repoEmployee.RetornarID(Id).HiringDate;
            txtHoursOfWork.Text = repoEmployee.RetornarID(Id).TimeOfWork;
            txtJob.Text = repoEmployee.RetornarID(Id).Job;
            txtLastName.Text = repoEmployee.RetornarID(Id).LastName;
            txtMail.Text = repoEmployee.RetornarID(Id).Email;
            txtNeighborhood.Text = repoEmployee.RetornarID(Id).Neighborhood;
            txtNickName.Text = repoEmployee.RetornarID(Id).NickName;
            txtObservation.Text = repoEmployee.RetornarID(Id).Observation;
            txtPassport.Text = repoDocument.RetornarID(IdDocument).Passport;
            txtPhone.Text = repoEmployee.RetornarID(Id).Phone;
            txtSalary.Text = repoEmployee.RetornarID(Id).Salary;
            txtSalaryObservation.Text = repoEmployee.RetornarID(Id).SalaryObservation;
            txtVacation.Text = repoEmployee.RetornarID(Id).Vacation;
            ddlSex.SelectedValue = repoEmployee.RetornarID(Id).Sex;
            ddlTemp.SelectedValue = repoEmployee.RetornarID(Id).Temp.ToString();
        }

        protected void hplDelete_Click(object sender, EventArgs e)
        {
            Delete deleteEmployee = new Delete();
            try
            {
                deleteEmployee.DeleteEmployee(Id);
                Response.Redirect("/humans/manage-employee.aspx");
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }

        protected void hplSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        protected void hplAddUser_Click(object sender, EventArgs e)
        {
            Save();
            Response.Redirect("/humans/add-user.aspx?id=" + Id);
        }
        private void Save()
        {
            Update updateEmployee = new Update();
            try
            {
                updateEmployee.UpdateEmployee(Id, 1, txtBrazilCPF.Text, txtBrazilRG.Text, txtPassport.Text, txtBrazilCDTNumber.Text, txtBrazilCDTEmitionDate.Text, txtBrazilCDTSigla.Text, txtBrazilCDTSerie.Text, txtBrazilCDTPIS.Text, txtBrazilCDTCadastro.Text, txtBrazilCNH.Text, "SEM CNPJ", txtFirstName.Text, txtLastName.Text, txtNickName.Text, txtMail.Text, txtPhone.Text, txtAddress.Text, txtBirtday.Text, txtObservation.Text, " ", txtNeighborhood.Text, txtCity.Text, " ", ddlSex.SelectedItem.Value, txtJob.Text, txtHiringDate.Text, txtSalaryObservation.Text, txtSalary.Text, txtVacation.Text, txtHoursOfWork.Text, txtDaysAtWork.Text, int.Parse(ddlTemp.SelectedItem.Value));
                lblErro.Text = "Salvo com sucesso";
            }
            catch (Exception ex)
            {
                lblErro.Text = "Erro: " + ex.Message;
            }
        }
    }
}