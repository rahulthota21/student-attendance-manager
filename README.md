# 🎓 Student Attendance Manager – WPF (.NET Framework 4.8)

A clean, responsive, and fully functional WPF desktop application to manage student attendance — built with C#, XAML, and .NET Framework 4.8.

> 💡 Perfect for college mini-projects or desktop admin tools.

---

## 🖼 Preview

![App Screenshot](fig1.png)

---

## 🛠 Features

- 🔐 Login screen (Dummy credentials: `admin` / `password`)
- 📋 Add / Edit / Delete students
- ✅ Mark attendance with checkboxes (Present/Absent)
- 📅 Date-based attendance selection
- 📊 Auto-generated report with attendance %
- 💾 In-memory database (easy to swap with SQL Server)

---

## 🚀 Tech Stack

- ⚙️ **WPF** (Windows Presentation Foundation)
- 🧠 **C#** (.NET Framework 4.8)
- 💻 XAML for UI
- 🗃 In-Memory `DataTable` (can integrate with SQL Server)
- ✍️ Visual Studio 2022 (Recommended)

---

## 🧪 How to Run

### ⚡ Option 1 (Recommended) – Visual Studio

1. Download [Visual Studio 2022](https://visualstudio.microsoft.com/vs/community/)
2. During install, select:
   - ✅ ".NET Desktop Development"
3. Clone this repo:
   ```bash
   git clone https://github.com/your-username/student-attendance-manager.git
   cd student-attendance-manager
   ```
4. Open `AttendanceApp.sln`
5. Press `F5` to run 🎉

---

### ⚙️ Option 2 – VS Code (Advanced users)

> ⚠️ WPF is not officially supported in VS Code UI. This path is only for MSBuild experts.

1. Install:
   - .NET Framework 4.8 Developer Pack
   - Visual Studio Build Tools with “.NET desktop development”
   - VS Code + C# Extension
2. Add `.vscode/tasks.json` to build using `msbuild`
3. Build with: `Ctrl+Shift+B`
4. Run: Navigate to `bin\Debug\AttendanceApp.exe`

---

## 📁 Folder Structure

```
AttendanceApp/
├── App.xaml / App.xaml.cs
├── LoginWindow.xaml / LoginWindow.xaml.cs
├── MainWindow.xaml / MainWindow.xaml.cs
├── Views/
│   ├── StudentsView.xaml
│   ├── AttendanceView.xaml
│   └── ReportsView.xaml
├── Models/
│   └── StudentModel.cs
├── Services/
│   └── AttendanceDataService.cs
├── Assets/
│   └── fig1.png
```

---

## 📌 Future Enhancements

- 💽 Add SQL Server or SQLite integration
- 📈 Export report to CSV
- 🔔 Notifications or alerts
- 🌐 Multi-user login system

---

## 🤝 Contributing

PRs are welcome! Please fork this repo and open a pull request. Make sure to test changes locally.

---

## 📃 License

MIT © 2025 — [Your Name](https://github.com/your-username)