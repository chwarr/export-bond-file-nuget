A set of example projects that demonstrates how to create a NuGet package
that exports a .bond file that another project can use as a base.

* lib-with-bond.csproj: produces the NuGet package "LibWithBond"
    * includes the generated code for `SomeBase`
    * includes the base.bond file so other projects can import it
    * arranges for consuming projects to run Bond.CSharp's codegen
    * adds the package's .bond files to `BondImportDirectory`
* consume-lib.csproj: uses the NuGet package produced by
  lib-with-bond.csproj
    * derives a struct from `SomeBase`
    * instantiates that struct

This example was created to answer the StackOverflow question [Compile .bond
files of projects using my NuGet package][1].

# Build

```powershell
cd lib-with-bond
dotnet pack
cd ..\consume-lib
dotnet build
```

# License

Copyright 2021 Microsoft

Released under the terms of the MIT license.

[1]: https://stackoverflow.com/questions/66038274/compile-bond-files-of-projects-using-my-nuget-package/
