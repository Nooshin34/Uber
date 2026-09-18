using Uber.Business.Businesses;
using UberApp.Domain;

namespace UberApp.Forms
{
    public partial class CarRegistrationForm : Form
    {
        List<User> users = new List<User>();
        List<Car> cars = new List<Car>();
        Car? targetCar = null;
        UserBusiness userBusiness = new();
        CarBusiness carBusiness = new();
        long? lockedUserId = null;

        public CarRegistrationForm()
        {
            InitializeComponent();
            LoadOwners();
            LoadCars();
        }

        public CarRegistrationForm(long userId, string ownerName) : this()
        {
            lockedUserId = userId;
            SelectOwner(userId);
            ownerComboBox.Enabled = false;
            Text = $"Car Registration - {ownerName}";
        }

        private void LoadOwners()
        {
            users = userBusiness.GetAll();
            ownerComboBox.DataSource = null;
            ownerComboBox.DisplayMember = nameof(User.FullName);
            ownerComboBox.ValueMember = nameof(User.Id);
            ownerComboBox.DataSource = users;
        }

        private void LoadCars()
        {
            long? userId = GetSelectedUserId();
            cars = userId.HasValue
                ? carBusiness.GetByUserId(userId.Value)
                : carBusiness.GetAll();
            refreshForm();
        }

        private long? GetSelectedUserId()
        {
            if (lockedUserId.HasValue)
                return lockedUserId;

            if (ownerComboBox.SelectedValue is long id)
                return id;

            if (ownerComboBox.SelectedValue != null && long.TryParse(ownerComboBox.SelectedValue.ToString(), out long parsedId))
                return parsedId;

            return null;
        }

        private void SelectOwner(long userId)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Id == userId)
                {
                    ownerComboBox.SelectedValue = userId;
                    break;
                }
            }
            LoadCars();
        }

        private void addCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                long? userId = GetSelectedUserId();
                if (!userId.HasValue)
                {
                    MessageBox.Show("Please select a user...");
                    return;
                }

                if (!int.TryParse(yearTextBox.Text, out int year))
                    throw new Exception("سال ساخت خودرو را درست وارد نمایید");

                Car car = Car.Create(
                    userId.Value,
                    brandTextBox.Text,
                    modelTextBox.Text,
                    colorTextBox.Text,
                    plateTextBox.Text,
                    year);

                carBusiness.Add(car);
                LoadCars();
                resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (targetCar is null)
                {
                    MessageBox.Show("لطفا ابتدا یک خودرو را انتخاب نمایید");
                    return;
                }

                if (!int.TryParse(yearTextBox.Text, out int year))
                    throw new Exception("سال ساخت خودرو را درست وارد نمایید");

                targetCar.UpdateBrand(brandTextBox.Text);
                targetCar.UpdateModel(modelTextBox.Text);
                targetCar.UpdateColor(colorTextBox.Text);
                targetCar.UpdatePlateNumber(plateTextBox.Text);
                targetCar.UpdateYear(year);

                carBusiness.Update(targetCar);
                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (targetCar is null)
                {
                    MessageBox.Show("لطفا ابتدا یک خودرو را انتخاب نمایید");
                    return;
                }

                carBusiness.Delete(targetCar);
                targetCar = null;
                LoadCars();
                resetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetForm()
        {
            brandTextBox.Text = string.Empty;
            modelTextBox.Text = string.Empty;
            colorTextBox.Text = string.Empty;
            plateTextBox.Text = string.Empty;
            yearTextBox.Text = string.Empty;
            targetCar = null;
        }

        private void refreshForm()
        {
            carDataGridView.DataSource = null;
            carDataGridView.DataSource = cars;
            carDataGridView.Refresh();
        }

        private void carDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = carDataGridView.Rows[e.RowIndex];
            var id = long.Parse(row.Cells["Id"].Value.ToString() ?? "0");
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Id == id)
                {
                    targetCar = cars[i];
                    brandTextBox.Text = cars[i].Brand;
                    modelTextBox.Text = cars[i].Model;
                    colorTextBox.Text = cars[i].Color;
                    plateTextBox.Text = cars[i].PlateNumber;
                    yearTextBox.Text = cars[i].Year.ToString();
                    break;
                }
            }
        }

        private void ownerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lockedUserId.HasValue)
                return;

            targetCar = null;
            LoadCars();
        }
    }
}
