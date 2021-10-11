#!/bin/bash
if ! [ $# -eq 1 ]; then
  echo "./create_project.sh <Project_name>: This script receives one argument (the project name)."
  exit 1
fi

if ! [ -x "$(command -v dotnet)" ]; then
  sh ./dotnet-install.sh
fi

# - Go to the directory where you want your project to be and run:

dotnet new sln -o TDD-$1

# - Go to that newly created directory

cd TDD-$1

# - Create a new class lib:

dotnet new classlib -o $1.Library

# **NOTE:** The dotnet new classlib command creates a new class library project in the Project.Library folder. The new class library will contain the code to be tested.

# - Rename the file Class1.cs to ProjectService.cs

mv ./$1.Library/Class1.cs ./$1.Library/$1Service.cs

# - Run the following command to add the class library project to the solution:

dotnet sln add ./$1.Library/$1.Library.csproj

# - Create the Project.Tests project by running the following command:

dotnet new mstest -o $1.Tests

# - Rename the file UnitTest1.cs to ProjectTests.cs

mv ./$1.Tests/UnitTest1.cs ./$1.Tests/$1Tests.cs

# - Add the test project to the solution file by running the following command:

dotnet sln add ./$1.Tests/$1.Tests.csproj

# - Add the ProjectService class library as a dependency to the Project.Tests project:

dotnet add ./$1.Tests/$1.Tests.csproj reference ./$1.Library/$1.Library.csproj
