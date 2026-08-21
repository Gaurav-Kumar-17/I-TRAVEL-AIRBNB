using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public class Property
        {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Type { get; set; }
            public decimal PricePerNight { get; set; }
            public int Guests { get; set; }

            public override string ToString()
            {
                return Name + " - " + Location;
            }
        }

        private List<Property> properties = new List<Property>();

        private ComboBox cmbLocation;
        private NumericUpDown numGuests;
        private NumericUpDown numNights;
        private ComboBox cmbProperty;
        private Label lblPrice;
        private Label lblTotal;
        private TextBox txtName;
        private TextBox txtEmail;
        private Button btnSearch;
        private Button btnBook;
        private DataGridView dgvProperties;

        public Form1()
        {
            InitializeComponent();
            CreateProperties();
            CreateInterface();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

//DATA FOR THE APPARTMENTS

        private void CreateProperties()
        {
            properties.Add(new Property
            {
                Name = "Luxury Apartment",
                Location = "Hyderabad",
                Type = "Apartment",
                PricePerNight = 2500,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Beach View Villa",
                Location = "Goa",
                Type = "Villa",
                PricePerNight = 4500,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Modern City Room",
                Location = "Mumbai",
                Type = "Private Room",
                PricePerNight = 1800,
                Guests = 2
            });

            properties.Add(new Property
            {
                Name = "Mountain Cottage",
                Location = "Manali",
                Type = "Cottage",
                PricePerNight = 3200,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Premium House",
                Location = "Delhi",
                Type = "House",
                PricePerNight = 3800,
                Guests = 7
            });

            properties.Add(new Property
            {
                Name = "Budget Studio",
                Location = "Bangalore",
                Type = "Studio",
                PricePerNight = 1500,
                Guests = 2
            });

            properties.Add(new Property
            {
                Name = "Rental House",
                Location = "Kolkata",
                Type = "House",
                PricePerNight = 1500,
                Guests = 2
            });

            properties.Add(new Property
            {
                Name = "High Studio",
                Location = "Mumbai",
                Type = "Studio",
                PricePerNight = 6500,
                Guests = 7
            });

            properties.Add(new Property
            {
                Name = "Classic Studio",
                Location = "Delhi",
                Type = "Studio",
                PricePerNight = 5500,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Luxury Beach Villa",
                Location = "Goa",
                Type = "Villa",
                PricePerNight = 8500,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Modern City Apartment",
                Location = "Mumbai",
                Type = "Apartment",
                PricePerNight = 6500,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Cozy Mountain Cottage",
                Location = "Manali",
                Type = "Cottage",
                PricePerNight = 4500,
                Guests = 3
            });

            properties.Add(new Property
            {
                Name = "Royal Heritage House",
                Location = "Jaipur",
                Type = "House",
                PricePerNight = 7500,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Peaceful Lake Resort",
                Location = "Udaipur",
                Type = "Resort",
                PricePerNight = 9500,
                Guests = 8
            });

            properties.Add(new Property
            {
                Name = "Elegant Garden Villa",
                Location = "Bangalore",
                Type = "Villa",
                PricePerNight = 7200,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Cozy Downtown Flat",
                Location = "Hyderabad",
                Type = "Apartment",
                PricePerNight = 4800,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Royal Palace Stay",
                Location = "Agra",
                Type = "House",
                PricePerNight = 6800,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Snow Valley Retreat",
                Location = "Shimla",
                Type = "Cottage",
                PricePerNight = 5200,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Beachside Paradise",
                Location = "Kochi",
                Type = "Resort",
                PricePerNight = 8800,
                Guests = 7
            });

            properties.Add(new Property
            {
                Name = "Modern Lake View",
                Location = "Bhopal",
                Type = "Apartment",
                PricePerNight = 4200,
                Guests = 3
            });

            properties.Add(new Property
            {
                Name = "Desert Camp House",
                Location = "Jaisalmer",
                Type = "House",
                PricePerNight = 6000,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Green Valley Home",
                Location = "Dehradun",
                Type = "Villa",
                PricePerNight = 5600,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Heritage Haveli",
                Location = "Jodhpur",
                Type = "Haveli",
                PricePerNight = 7800,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Sunset Seaside Room",
                Location = "Pondicherry",
                Type = "Studio",
                PricePerNight = 3900,
                Guests = 2
            });

            properties.Add(new Property
            {
                Name = "Sunrise Luxury Apartment",
                Location = "Chennai",
                Type = "Apartment",
                PricePerNight = 5800,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Hilltop Wooden Cabin",
                Location = "Mussoorie",
                Type = "Cabin",
                PricePerNight = 4900,
                Guests = 3
            });

            properties.Add(new Property
            {
                Name = "Royal Garden Estate",
                Location = "Lucknow",
                Type = "Villa",
                PricePerNight = 8200,
                Guests = 7
            });

            properties.Add(new Property
            {
                Name = "Ocean Breeze Villa",
                Location = "Visakhapatnam",
                Type = "Villa",
                PricePerNight = 7600,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Peaceful Countryside Home",
                Location = "Pune",
                Type = "House",
                PricePerNight = 5100,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Modern Business Suite",
                Location = "Gurgaon",
                Type = "Studio",
                PricePerNight = 6200,
                Guests = 2
            });

            properties.Add(new Property
            {
                Name = "Riverside Retreat",
                Location = "Rishikesh",
                Type = "Cottage",
                PricePerNight = 4700,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Grand Heritage Villa",
                Location = "Mysore",
                Type = "Villa",
                PricePerNight = 7300,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Urban Comfort Home",
                Location = "Kolkata",
                Type = "Apartment",
                PricePerNight = 4400,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Forest View Cottage",
                Location = "Nainital",
                Type = "Cottage",
                PricePerNight = 5500,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Luxury Skyline Suite",
                Location = "Noida",
                Type = "Studio",
                PricePerNight = 6900,
                Guests = 3
            });

            properties.Add(new Property
            {
                Name = "Royal Desert Villa",
                Location = "Jaisalmer",
                Type = "Villa",
                PricePerNight = 8700,
                Guests = 6
            });

            properties.Add(new Property
            {
                Name = "Green Hills Homestay",
                Location = "Ooty",
                Type = "Homestay",
                PricePerNight = 4600,
                Guests = 4
            });

            properties.Add(new Property
            {
                Name = "Coastal Luxury Resort",
                Location = "Mangalore",
                Type = "Resort",
                PricePerNight = 9200,
                Guests = 8
            });

            properties.Add(new Property
            {
                Name = "Historic City House",
                Location = "Amritsar",
                Type = "House",
                PricePerNight = 5300,
                Guests = 5
            });

            properties.Add(new Property
            {
                Name = "Taj Hotel",
                Location = "Varansi",
                Type = "Hotel",
                PricePerNight = 8300,
                Guests = 2
            });


        }

// USER INTERFACE

        private void CreateInterface()
        {
            this.Text = "Airbnb Property Booking System";
            this.Size = new Size(1100, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#090949");

// ---------------- HEADER ----------------

            Label title = new Label();
            title.Text = "I Travel";
            title.Font = new Font("Arial", 28, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(40, 20);
            title.AutoSize = true;
            this.Controls.Add(title);

            Label subtitle = new Label();
            subtitle.Text = "Get The Perfect Location To Stay";
            subtitle.Font = new Font("Arial", 14);
            subtitle.ForeColor = Color.White;
            subtitle.Location = new Point(43, 65);
            subtitle.AutoSize = true;
            this.Controls.Add(subtitle);

// ---------------- SEARCH AREA ----------------

            GroupBox searchBox = new GroupBox();
            searchBox.Text = "Search Properties";
            searchBox.Font = new Font("Arial", 11, FontStyle.Bold);
            searchBox.Location = new Point(40, 110);
            searchBox.ForeColor = Color.White;
            searchBox.Size = new Size(1000, 110);
            this.Controls.Add(searchBox);

            Label locationLabel = new Label();
            locationLabel.Text = "Location";
            locationLabel.Location = new Point(20, 30);
            locationLabel.AutoSize = true;
            locationLabel.ForeColor = Color.White;
            searchBox.Controls.Add(locationLabel);

            cmbLocation = new ComboBox();
            cmbLocation.Location = new Point(20, 55);
            cmbLocation.Size = new Size(180, 30);
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbLocation.Items.Add("All Locations");

            foreach (string location in properties
                .Select(p => p.Location)
                .Distinct())
            {
                cmbLocation.Items.Add(location);
            }

            cmbLocation.SelectedIndex = 0;
            searchBox.Controls.Add(cmbLocation);

            Label guestsLabel = new Label();
            guestsLabel.Text = "Guests";
            guestsLabel.Location = new Point(230, 30);
            guestsLabel.AutoSize = true;
            searchBox.Controls.Add(guestsLabel);

            numGuests = new NumericUpDown();
            numGuests.Minimum = 1;
            numGuests.Maximum = 20;
            numGuests.Value = 1;
            numGuests.Location = new Point(230, 55);
            numGuests.Size = new Size(100, 30);
            searchBox.Controls.Add(numGuests);

            Label nightsLabel = new Label();
            nightsLabel.Text = "Nights";
            nightsLabel.Location = new Point(360, 30);
            nightsLabel.AutoSize = true;
            searchBox.Controls.Add(nightsLabel);

            numNights = new NumericUpDown();
            numNights.Minimum = 1;
            numNights.Maximum = 30;
            numNights.Value = 1;
            numNights.Location = new Point(360, 55);
            numNights.Size = new Size(100, 30);
            numNights.ValueChanged += NumNights_ValueChanged;
            searchBox.Controls.Add(numNights);

            btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.Location = new Point(500, 52);
            btnSearch.Size = new Size(130, 35);
            btnSearch.BackColor = Color.FromArgb(220, 50, 80);
            btnSearch.ForeColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Click += BtnSearch_Click;
            searchBox.Controls.Add(btnSearch);

// ---------------- PROPERTY TABLE ----------------

            Label listTitle = new Label();
            listTitle.Text = "Available Properties";
            listTitle.Font = new Font("Arial", 15, FontStyle.Bold);
            listTitle.Location = new Point(40, 240);
            listTitle.AutoSize = true;
            listTitle.ForeColor = Color.White;
            this.Controls.Add(listTitle);

            dgvProperties = new DataGridView();
            dgvProperties.Location = new Point(40, 275);
            dgvProperties.Size = new Size(1000, 170);
            dgvProperties.AutoGenerateColumns = true;
            dgvProperties.ReadOnly = true;
            dgvProperties.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvProperties.MultiSelect = false;
            dgvProperties.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.Controls.Add(dgvProperties);

            LoadProperties(properties);

            // ---------------- BOOKING SECTION ----------------

            GroupBox bookingBox = new GroupBox();
            bookingBox.Text = "Booking Details";
            bookingBox.Font = new Font("Arial", 11, FontStyle.Bold);
            bookingBox.Location = new Point(40, 465);
            bookingBox.Size = new Size(1000, 210);
            bookingBox.ForeColor = Color.White;
            this.Controls.Add(bookingBox);

            Label propertyLabel = new Label();
            propertyLabel.Text = "Property";
            propertyLabel.Location = new Point(20, 30);
            propertyLabel.AutoSize = true;
            propertyLabel.ForeColor = Color.White;
            bookingBox.Controls.Add(propertyLabel);

            cmbProperty = new ComboBox();
            cmbProperty.Location = new Point(20, 55);
            cmbProperty.Size = new Size(250, 30);
            cmbProperty.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (Property property in properties)
            {
                cmbProperty.Items.Add(property);
            }

            if (cmbProperty.Items.Count > 0)
                cmbProperty.SelectedIndex = 0;

            cmbProperty.SelectedIndexChanged += CmbProperty_SelectedIndexChanged;

            bookingBox.Controls.Add(cmbProperty);

            Label nameLabel = new Label();
            nameLabel.Text = "Guest Name";
            nameLabel.Location = new Point(300, 30);
            nameLabel.AutoSize = true;
            bookingBox.Controls.Add(nameLabel);

            txtName = new TextBox();
            txtName.Location = new Point(300, 55);
            txtName.Size = new Size(200, 30);
            bookingBox.Controls.Add(txtName);

            Label emailLabel = new Label();
            emailLabel.Text = "Email";
            emailLabel.Location = new Point(530, 30);
            emailLabel.AutoSize = true;
            bookingBox.Controls.Add(emailLabel);

            txtEmail = new TextBox();
            txtEmail.Location = new Point(530, 55);
            txtEmail.Size = new Size(200, 30);
            bookingBox.Controls.Add(txtEmail);

            lblPrice = new Label();
            lblPrice.Text = "Price: ₹0 / night";
            lblPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lblPrice.Location = new Point(20, 105);
            lblPrice.AutoSize = true;
            bookingBox.Controls.Add(lblPrice);

            lblTotal = new Label();
            lblTotal.Text = "Total: ₹0";
            lblTotal.Font = new Font("Arial", 14, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(220, 50, 80);
            lblTotal.Location = new Point(300, 105);
            lblTotal.AutoSize = true;
            bookingBox.Controls.Add(lblTotal);

            btnBook = new Button();
            btnBook.Text = "Confirm Booking";
            btnBook.Location = new Point(750, 52);
            btnBook.Size = new Size(180, 40);
            btnBook.BackColor = Color.FromArgb(220, 50, 80);
            btnBook.ForeColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Arial", 10, FontStyle.Bold);
            btnBook.Click += BtnBook_Click;

            bookingBox.Controls.Add(btnBook);

            UpdatePrice();
        }

// LOAD PROPERTY TABLE

        private void LoadProperties(List<Property> list)
        {
            dgvProperties.DataSource = null;

            dgvProperties.DataSource = list.Select(p => new
            {
                Property = p.Name,
                Location = p.Location,
                Type = p.Type,
                Price_Per_Night = "₹" + p.PricePerNight,
                Maximum_Guests = p.Guests
            }).ToList();
        }

// SEARCH

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string location = cmbLocation.SelectedItem.ToString();
            int guests = (int)numGuests.Value;

            List<Property> result;

            if (location == "All Locations")
            {
                result = properties
                    .Where(p => p.Guests >= guests)
                    .ToList();
            }
            else
            {
                result = properties
                    .Where(p =>
                        p.Location == location &&
                        p.Guests >= guests)
                    .ToList();
            }

            LoadProperties(result);

            if (result.Count == 0)
            {
                MessageBox.Show(
                    "No properties found for your search.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

// PRICE CALCULATION

        private void UpdatePrice()
        {
            if (cmbProperty == null ||
                cmbProperty.SelectedItem == null)
                return;

            Property property =
                cmbProperty.SelectedItem as Property;

            decimal total =
                property.PricePerNight *
                numNights.Value;

            lblPrice.Text =
                "Price: ₹" +
                property.PricePerNight +
                " / night";

            lblTotal.Text =
                "Total: ₹" +
                total.ToString("N0");
        }

        private void NumNights_ValueChanged(
            object sender,
            EventArgs e)
        {
            UpdatePrice();
        }

        private void CmbProperty_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdatePrice();
        }

// BOOK PROPERTY

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter your name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please enter your email.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbProperty.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a property.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Property property =
                cmbProperty.SelectedItem as Property;

            decimal total =
                property.PricePerNight *
                numNights.Value;

            string bookingId =
                "AIR" + DateTime.Now.ToString("yyyyMMddHHmmss");

            decimal gstRate = 0.18m;
            decimal gstAmount = total * gstRate;
            decimal finalAmount = total + gstAmount;

            string message =
                "BOOKING CONFIRMED!\n\n" +
                "Booking ID: " + bookingId + "\n" +
                "Guest: " + txtName.Text + "\n" +
                "Email: " + txtEmail.Text + "\n\n" +
                "Property: " + property.Name + "\n" +
                "Location: " + property.Location + "\n" +
                "Guests: " + numGuests.Value + "\n" +
                "Nights: " + numNights.Value + "\n" +
                "Price/Night: ₹" + property.PricePerNight.ToString("N0") + "\n" +
                "Subtotal: ₹" + total.ToString("N0") + "\n" +
                "GST (18%): ₹" + gstAmount.ToString("N0") + "\n" +
                "Total Amount: ₹" + finalAmount.ToString("N0");

            MessageBox.Show(
                message,
                "Airbnb - Booking Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}