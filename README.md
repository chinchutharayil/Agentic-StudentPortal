# Students Portal - ASP.NET Razor Pages Application

A simple ASP.NET Core Razor Pages web application for managing student records with full CRUD (Create, Read, Update, Delete) operations.

## Features

- **View Students**: Display a list of all students with their details
- **Add Student**: Form to create new student records
- **Edit Student**: Update existing student information
- **Delete Student**: Remove students with confirmation page

## Technology Stack

- ASP.NET Core 8.0
- Razor Pages
- In-memory storage (data survives only during app lifetime)
- Bootstrap 5 (minimal styling)

## Project Structure

```
StudentPortal/
├── Models/
│   └── Student.cs              # Student data model
├── Services/
│   └── StudentService.cs       # In-memory storage service (singleton)
├── Pages/
│   ├── Students/
│   │   ├── Index.cshtml(.cs)   # List all students
│   │   ├── Create.cshtml(.cs)  # Add new student
│   │   ├── Edit.cshtml(.cs)    # Edit student
│   │   └── Delete.cshtml(.cs)  # Delete confirmation
│   └── Shared/
│       └── _Layout.cshtml      # Main layout
├── Program.cs                   # Application entry point
└── appsettings.json            # Configuration
```

## Student Model

Each student has the following fields:
- **Id**: Unique identifier (auto-generated)
- **Name**: Student's full name
- **Email**: Email address
- **Age**: Student's age
- **Enrollment Date**: Date of enrollment

## Running the Application

### Prerequisites
- .NET 8.0 SDK or later

### Steps

1. Clone the repository
2. Navigate to the project directory
3. Run the application:

```bash
dotnet run
```

4. Open your browser and navigate to:
   - `http://localhost:5000` (or the URL shown in the console)

5. Click on "Manage Students" to access the Students Portal

## Usage

### Viewing Students
Navigate to `/Students` to see the list of all students.

### Adding a New Student
1. Click "Add New Student"
2. Fill in the form with student details
3. Click "Add Student"

### Editing a Student
1. Click "Edit" next to the student you want to modify
2. Update the information
3. Click "Update Student"

### Deleting a Student
1. Click "Delete" next to the student you want to remove
2. Confirm the deletion on the confirmation page
3. Click "Delete" to confirm

## Notes

- **Data Persistence**: The application uses in-memory storage. All data will be lost when the application stops.
- **Thread Safety**: The StudentService implements proper locking mechanisms to handle concurrent requests safely.
- **Sample Data**: The application comes pre-loaded with 3 sample students for demonstration purposes.

## Security Considerations

- Input validation is handled through ASP.NET Core model binding
- XSS protection through automatic HTML encoding in Razor Pages
- Thread-safe operations using lock statements in the service layer
- No persistent database means no SQL injection risks

## License

This is a demonstration project created for educational purposes.
