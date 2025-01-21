# Overview

This document provides instructions on how to use and install the `DPB2.Plugin.Template` package. The template is designed to help developers streamline the process of creating plugins for their applications.

## Installation

To install the template package, run the following command in your terminal:

```sh
dotnet new --install .\DPB2.Plugin.Template.3.0.0.nupkg --force
```

**Notes:**

- Ensure that you have the `.nupkg` file downloaded and located in the specified path (`.\`).
- The `--force` option ensures that any existing installation of the same template is overwritten.
- Replace `.\DPB2.Plugin.Template.3.0.0.nupkg` with the full path to the `.nupkg` file if it is not in the current directory.

## Usage

After successful installation, you can create a new project using this template by executing the following command:

```sh
dotnet new <template-name> -n <project-name>
```

**Parameters:**

- `<template-name>`: Replace this with the name of the template provided by the `DPB2.Plugin.Template` package.
- `<project-name>`: Replace this with the desired name for your new project.

**Example:**

```sh
dotnet new dpb2plugin -n MyNewPlugin
```

This will create a new project named `MyNewPlugin` using the `DPB2.Plugin.Template`.
