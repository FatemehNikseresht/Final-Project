using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class frmPerson : Form
    {
        private readonly PersonViewModel _personViewModel;
        public frmPerson()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personViewModel.FillGrid();
           
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmName().Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var PersonSaveDto = new PersonSaveDto()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
            };
            _personViewModel.Save(PersonSaveDto);
            MessageBox.Show("Save Is Done Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var PersonDeleteDto = new PersonDeleteDto()
            {
                //you must convert string to int
               Id=Int32.Parse(txtID.Text),
            };
            _personViewModel.Delete(PersonDeleteDto);
            MessageBox.Show("Delete Is Done Successfully");
        }
    }
}