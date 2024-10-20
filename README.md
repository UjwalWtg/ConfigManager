# SuperConfigManager

A simple library to manage application configurations.

## Features

- Load configurations from JSON files.
- Load configurations from environment variables.
- Strongly typed configuration settings.

## Installation

You can install the library via NuGet

## Usage

### Load from JSON File

```csharp
using SuperConfigManager;

var configLoader = new ConfigLoader();
var settings = configLoader.LoadFromJson("path/to/config.json");
Console.WriteLine(settings.ApiUrl);

var configLoader = new ConfigLoader();
var settings = configLoader.LoadFromEnvironmentVariables();
Console.WriteLine(settings.ApiUrl);
