## NameSorter
* Given a set of names, order that set first by last name, then by any given names the person may have. A
name must have at least 1 given name and may have up to 3 given names.

## Technologies
.NetCore, MSTest, Merge Sort : top-down approach

## INameComparer<>
This interface represents for name comparing.

## ISorter<>
This interface represents for name sorting.

## IFileHelper<>
This interface represents for read and write file.

## How to build code
Clone the repository git clone https://github.com/spurtik/NameSort.git

# NameSorter directory restore required packages by running:
* dotnet restore

# Next, build the solution by running:
* dotnet build

# Run the console application by:
* dotnet run

# Unit testing, within the NameSorter.Test directory, test application by:
* dotnet test

# Reference sites
* https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
* https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
