# browserstack-camera-injection-ios-csharp

This repository demonstrates how to test the Camera Injection feature using Appium C# on BrowserStack App Automate.

### Requirements

1. Visual Studio 2019

    - If not installed, download and install Visual Studio 2019 from [here](https://visualstudio.microsoft.com/vs/)

### Getting Started

1. Configuring the test

    - Clone the repo
    - Add your BrowserStack username and access key to your environment variables - 
    ```
        export BROWSERSTACK_USERNAME=<browserstack_username> 
        export BROWSERSTACK_ACCESS_KEY=<browserstack_access_key>
    ```
    - - Update `bs://<app_url>` in [`Program.cs`](Program.cs) file with the obtained app URL after the previous step.


2. Running the test
    - Directly run the test using Visual Studio. Or if you want to use terminal then run - 
    ```
        dotnet build
        dotnet run
    ```

3. Viewing the results
    - Go to your App Automate [dashboard](https://www.browserstack.com/app-automate) to view the results.
