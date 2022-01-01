[![Build Status](https://dev.azure.com/kaysho109/Localman.NET/_apis/build/status/kaysho.Localman.NET?branchName=master)](https://dev.azure.com/kaysho109/Localman.NET/_build/latest?definitionId=11&branchName=master)

# Localman.NET
A .NET library that provides Nigerian based locations list and info such as States and Local Government Areas


## Setup
- To use the library in your projects,follow the steps below;

1. Download the current version through [NuGet](https://www.nuget.org/packages/Localman.NET/) and install it in your .NET project.

```
# How to use

var localman = new Localman.NET.Localman();

// get list of all states in Nigeria
var states = localman.GetAllStates();

// get list of all local government areas in Lagos State
 var lgasInLagos = localman.GetLGAs(State.LAGOS);

// get latitude of Lagos State
var latInLagos = localman.GetLatitude(State.LAGOS);
```
