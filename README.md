# Forest

A simple C# console application demonstrating object-oriented programming concepts with a `Forest` class. This program showcases class properties, constructors, fields, and static variables through a forest management example.

## Features

- **Forest Class**: Models a forest with properties like Name, Trees, Age, and Biome
- **Object Tracking**: Uses static variables to track the number of forests created
- **Property Validation**: Demonstrates getter/setter patterns with validation logic
- **Console Output**: Displays forest information through a simple command-line interface

## Requirements

- **.NET 10.0** or later
- **Visual Studio Code** (recommended) or Visual Studio 2022+
- **Git** (for cloning the repository)

## Installation & Setup

### Option 1: Using Visual Studio Code (Recommended)

#### Step 1: Install Visual Studio Code
1. Go to [https://code.visualstudio.com](https://code.visualstudio.com)
2. Click the download button for your operating system (Windows, macOS, or Linux)
3. Run the installer and follow the on-screen instructions
4. Launch Visual Studio Code once installed

#### Step 2: Install the C# Dev Kit Extension
1. Open Visual Studio Code
2. Click the **Extensions** icon on the left sidebar (or press `Ctrl+Shift+X`)
3. Search for **"C# Dev Kit"** (published by Microsoft)
4. Click **Install**
5. Restart Visual Studio Code when prompted

#### Step 3: Install .NET SDK
1. Go to [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Download **.NET 10.0** (or the latest stable version)
3. Run the installer and follow the on-screen instructions
4. Verify installation by opening a terminal/command prompt and typing:
   ```
   dotnet --version
   ```

#### Step 4: Clone and Open the Project
1. Open a terminal/command prompt
2. Navigate to where you want to store the project:
   ```
   cd Documents
   ```
3. Clone the repository:
   ```
   git clone https://github.com/strikeouts27/Forest.git
   cd Forest
   ```
4. Open the project in VS Code:
   ```
   code .
   ```

#### Step 5: Run the Program
1. In VS Code, open the terminal (`` Ctrl+` `` or `View` > `Terminal`)
2. Type the following command:
   ```
   dotnet run
   ```
3. The program will compile and execute, displaying forest information in the terminal

### Option 2: Using Visual Studio 2022+

1. Download and install [Visual Studio 2022 Community](https://visualstudio.microsoft.com/vs/community/) (or Professional/Enterprise)
2. During installation, select the **.NET desktop development** workload
3. Clone the repository:
   ```
   git clone https://github.com/strikeouts27/Forest.git
   ```
4. Open `Forest.slnx` in Visual Studio
5. Press `F5` to run the program, or right-click the project and select **Run**

## Project Structure

```
Forest/
├── Forest.cs              # Forest class definition
├── Program.cs             # Entry point and main application logic
├── Forest.csproj          # Project configuration file
├── Properties/
│   └── launchSettings.json
├── Dockerfile             # Docker support
└── README.md             # This file
```

## How to Use

Simply run the program:
```
dotnet run
```

The program will:
1. Display the initial count of forests created (0)
2. Create two forest instances with names and descriptions
3. Display the updated count of forests created (2)
4. Print the forest information to the console

## Example Output

```
0
2
```

## Contributing

Feel free to fork this repository and submit pull requests for any improvements.

## License

This project is open source and available under the MIT License.

## Resources

- [.NET Documentation](https://docs.microsoft.com/dotnet)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Visual Studio Code Documentation](https://code.visualstudio.com/docs)
- [GitHub](https://github.com/strikeouts27/Forest)