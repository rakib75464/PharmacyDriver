# PharmacyDriver
This repository contains my Pharmacy Management System solution. I developed the user interface and business logic as a Windows Forms C# project and kept the source code inside the "Pharmacy Management System Solution" folder. This README explains what is in the repository, how the project is organized, and how to open and run it locally.

---

## How to open, build and run
Based on the project type (C# Windows Forms source files present):

1. Prerequisites
   - Visual Studio (Community/Professional/Enterprise) — any recent version that supports Windows Forms/C# projects (Visual Studio 2017/2019/2022+ will work for typical Windows Forms projects).  
   - A suitable .NET Framework or .NET runtime that the project targets. The exact target framework is set in the project (.csproj) file — open the `.csproj` in Visual Studio or a text editor to confirm the targeted framework version.

2. Steps I follow locally
   - Clone the repository:
     - git clone https://github.com/rakib75464/PharmacyDriver.git
   - Open Visual Studio and choose "Open a project or solution".
   - Browse to the `Pharmacy Management System Solution` folder and open the solution (.sln) or the project file inside `Pharmacy Management System` if a solution file is not present in the same folder.
   - Build the solution (Build → Build Solution).
   - Run (Start Debugging or Start Without Debugging) to launch the Windows Forms application.

If Visual Studio warns about missing target frameworks or NuGet packages, follow the prompts to install the required components. If you need the exact target framework, check the `.csproj` file inside the project folder.

---

## Database / data notes (what I observed)
- The `function` helper class references `SqlConnection`, `SqlCommand`, and `SqlDataReader` which indicates the application uses a SQL Server / ADO.NET connection for data access.  
Because database credentials and connection strings are sensitive, do not commit production credentials into source control. Use local configuration or environment variables and add a .gitignore entry for any local config files.

---

## Suggestions and housekeeping (what I'd do next)
- Add a `.gitignore` tailored for Visual Studio (to avoid committing bin/ and obj/ folders and user-specific files). Typical entries: `bin/`, `obj/`, `*.user`, `*.suo`, `*.pdb`, and other generated files.
- Remove (or re-create from clean sources) the `obj/Debug` tree from the repo if it was accidentally committed; those are build artifacts.
- If the project is intended to be shared, add a LICENSE file. I include a suggested license below; please choose or modify as you prefer.
- Add an `appsettings` or configuration sample (e.g., `app.config.example` or `README` section) documenting where to put the database connection string (so other developers can run the app locally).
- Add simple run/test instructions for common tasks (e.g., "How to seed sample data", if applicable).

---

## Contributing
If you or others want to contribute:
- Create feature branches from main (or master) and open pull requests.
- Use Visual Studio for changes to forms and designer files so the generated designer code stays consistent.
- Keep secrets (connection strings) out of the repository.

---

## License
The repository does not currently include a dedicated LICENSE file . If you want a permissive default, here is the MIT License text you can use — replace <MD. RAKIB HASAN> and <2023> as appropriate, or choose another license if you prefer.

MIT License
Copyright (c) <2023> <MD. RAKIB HASAN>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

## Contact
If you want to reach me about this repository:
- GitHub: https://github.com/rakib75464 (my account)
- Open an issue on this repository for questions, bugs, or feature requests.
