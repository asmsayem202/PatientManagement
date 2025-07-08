🏥 Patient Management System (ASP.NET Core MVC with Tailwind CSS)

A simple and user-friendly web application for managing patients and their prescribed medicines. Built with **ASP.NET Core MVC (.NET 8)**, **Entity Framework Core**, **SQL Server**, and styled using **Tailwind CSS**.

---

## 📌 Features

- 🔐 Doctor-only access (no roles implemented for simplicity)
- ➕ Add, Edit, and Delete Patients
- 💊 Add, Edit, and Delete Medicines for each patient
- 🔎 Search and filter patients
- 🔁 Pagination (5 patients per page)
- 🧾 View detailed patient history with medicine timeline
- 🖱️ AJAX-based delete confirmation (with modal and toast message)
- 🧩 Responsive and clean UI with Tailwind CSS
- 🎯 Lucide icons integration for better UX

---

## 🧑‍💻 Technologies Used

- **ASP.NET Core MVC (.NET 8)**
- **Entity Framework Core (Code-First)**
- **SQL Server**
- **Tailwind CSS**
- **jQuery (for AJAX)**
- **Lucide Icons**

---

## 📂 Project Structure

PatientManagement/
│
├── Controllers/
│ ├── PatientController.cs
│ └── MedicineController.cs
│
├── Models/
│ ├── Patient.cs
│ └── Medicine.cs
│
├── Views/
│ ├── Patient/
│ │ ├── Index.cshtml
│ │ ├── Create.cshtml
│ │ ├── Edit.cshtml
│ │ └── Details.cshtml
│ ├── Medicine/
│ │ └── Edit.cshtml
│ └── Shared/
│ └── _Layout.cshtml
│
├── Data/
│ └── ApplicationDbContext.cs
│
├── wwwroot/
│ └── css, js, lib (static files, Tailwind, jQuery)
│
├── appsettings.json
└── Program.cs

