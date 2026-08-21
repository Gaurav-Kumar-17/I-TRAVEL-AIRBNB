# 🏠 I-TRAVEL-AIRBNB

A simple **Airbnb-style property booking system** built using **C# and Windows Forms**.  
The application allows users to search for properties, check pricing, select the number of guests and nights, and confirm a booking with an automatically calculated GST-inclusive total.

## 📌 About the Project

**I-TRAVEL-AIRBNB** is a desktop-based property booking application developed as a C# Windows Forms project.

The main goal of this project is to demonstrate how a real-world accommodation booking system can be implemented using **Object-Oriented Programming, collections, LINQ, Windows Forms controls, event handling, filtering, and price calculations**.

The application contains multiple properties across different cities in India, with different property types, prices, and guest capacities.

---

## ✨ Features

### 🔎 Property Search
- Search properties by location.
- Filter properties according to the number of guests.
- Option to view properties from all locations.
- Displays a message when no matching property is found.

### 🏡 Property Listing
The application displays:
- Property name
- Location
- Property type
- Price per night
- Maximum number of guests

### 📅 Booking System
Users can:
- Select a property.
- Enter their name.
- Enter their email.
- Select the number of nights.
- Confirm their booking.

### 💰 Automatic Price Calculation
The application automatically calculates:
- Price per night
- Number of nights
- Subtotal
- 18% GST
- Final booking amount

### 🧾 Booking Confirmation
After booking, the application generates:
- Unique booking ID
- Guest information
- Property information
- Number of guests
- Number of nights
- Subtotal
- GST amount
- Final amount

### 🖥️ Desktop User Interface
The application includes a custom Windows Forms interface with:
- Header section
- Property search section
- Property table
- Booking section
- Custom colors and buttons
- User-friendly input controls

---

## 🛠️ Technologies Used

- **C#**
- **.NET Windows Forms**
- **Visual Studio Community**
- **LINQ**
- **Object-Oriented Programming (OOP)**
- **DataGridView**
- **ComboBox**
- **NumericUpDown**
- **MessageBox**

---

## 🧠 Concepts Demonstrated

This project demonstrates several important C# programming concepts:

- Classes and Objects
- Properties
- Lists and Collections
- LINQ queries
- Lambda expressions
- Encapsulation
- Event handling
- Conditional statements
- Exception-free input validation
- Decimal calculations
- Windows Forms controls
- Dynamic UI creation
- Data filtering
- String formatting

---

## 🏙️ Sample Locations

The application contains properties from multiple locations, including:

- Hyderabad
- Goa
- Mumbai
- Delhi
- Bangalore
- Manali
- Jaipur
- Udaipur
- Agra
- Shimla
- Kochi
- Pune
- Rishikesh
- Mysore
- Ooty
- Jaisalmer
- Chennai
- Noida
- Gurgaon
- Visakhapatnam

---

## 📂 Project Structure

```text
I-TRAVEL-AIRBNB/
│
├── Properties/
│
├── App.config
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Form2.cs
├── Form2.Designer.cs
├── Form2.resx
├── Program.cs
├── .gitignore
└── .gitattributes
```

---

## 🚀 How to Run

### 1. Clone the repository

```bash
git clone https://github.com/Gaurav-Kumar-17/I-TRAVEL-AIRBNB.git
```

### 2. Open the project

Open the `.sln` file in **Microsoft Visual Studio Community**.

### 3. Restore/Build the project

Use:

```text
Build → Build Solution
```

or press:

```text
Ctrl + Shift + B
```

### 4. Run the application

Press:

```text
F5
```

or click the **Start** button in Visual Studio.

---

## 🔄 Application Workflow

```text
Start Application
       ↓
View Available Properties
       ↓
Select Location
       ↓
Enter Number of Guests
       ↓
Search Properties
       ↓
Select Property
       ↓
Select Number of Nights
       ↓
Enter Guest Details
       ↓
Calculate Booking Amount
       ↓
Add 18% GST
       ↓
Confirm Booking
       ↓
Display Booking Confirmation
```

---

## 💡 Future Improvements

Some features that could be added in future versions:

- 🔐 User login and registration
- 🗄️ MySQL database integration
- 💳 Online payment system
- 📅 Check-in and check-out dates
- 🏠 Property image gallery
- ⭐ Property ratings and reviews
- 📧 Email booking confirmation
- 👤 User booking history
- 🛠️ Admin dashboard
- ➕ Add/remove properties dynamically
- 🔍 Advanced price and property-type filters

---

## 🎯 Project Purpose

This project was created to practice **C# Windows Forms development and object-oriented programming** while building a practical application inspired by real-world property booking platforms.

It focuses on turning basic programming concepts into a functional desktop application.

---

## 👨‍💻 Author

**Gaurav Kumar**

Computer Science & Engineering Student

---

## 📜 License

This project is created for **educational and learning purposes**.
