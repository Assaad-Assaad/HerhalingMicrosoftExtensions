# 🔄 HerhalingMicrosoftExtensions

This project demonstrates the use of Dependency Injection, Configuration, and Logging in a .NET application using the `ApplicationHostBuilder`. It serves as a practical exercise to understand service lifetimes, logging configuration, and configuration binding.

---

## 🎯 Project Overview

- Implements three services with different lifetimes:
  - **Service A**: Singleton — only one instance created during the runtime.
  - **Service B**: Scoped — created once per scope.
  - **Service C**: Transient — created every time it is requested.
- **Service A** is injected into **Service B** using Dependency Injection.
- Logging is configured with different log levels depending on the service namespace:
  - **Service A** logs at the **Trace** level.
  - All services in the project namespace log at **Debug** level.
  - Everything else logs at **Warning** level.
- Configuration is set up and bound to a custom configuration class, utilizing:
  - Environment variables
  - `appsettings.json`
- Demonstrates best practices with Microsoft Extensions for Dependency Injection, Logging, and Configuration.

---

## 🔧 Key Features

| Feature                  | Description                                                                 |
|--------------------------|-----------------------------------------------------------------------------|
| Dependency Injection     | Setup with singleton, scoped, and transient service lifetimes               |
| Service Dependencies    | Service A injected into Service B                                            |
| Logging Configuration   | Custom log levels based on namespaces and service roles                     |
| Configuration Binding   | Reads from `appsettings.json` and environment variables into config classes |

---

## 🚀 Running the Project

1. Clone the repository and open it in your preferred .NET development environment.
2. Ensure your `appsettings.json` and environment variables are properly configured.
3. Build and run the application.
4. Observe the logging output and service creation lifetimes.

---

## 📚 Technologies Used

- .NET (version depending on your setup)
- Microsoft.Extensions.DependencyInjection
- Microsoft.Extensions.Logging
- Microsoft.Extensions.Configuration
- ApplicationHostBuilder for setup

---

## 🎓 Notes

This project was created as a practical assignment to deepen understanding of Microsoft's Dependency Injection, Logging, and Configuration abstractions. It highlights how to configure and consume services with different lifetimes and logging strategies.
