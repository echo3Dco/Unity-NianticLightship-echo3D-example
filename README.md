# Unity-ARFoundation-echo3D-example
Example Unity project with Niantic Lightship and echo3D integrated.

Build in Unity version 2020.3.18f1 and tested on Unity versions 2020.1, 2019.4, 2018.4.

## Register
Don't have an API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
Follow the instructions on our [documentation page](https://docs.echo3D.co/unity/adding-ar-capabilities) to [set your API key](https://docs.echo3D.co/unity/adding-ar-capabilities#3-set-you-api-key).

## Run
* [Add the 3D model](https://docs.echo3D.co/quickstart/add-a-3d-model) to the console.
* [Set the API key](https://docs.echo3D.co/unity/using-the-sdk) in the `echo3D.cs` script inside the `echo3D/echo3D.prefab` using the the Inspector.
* [Set your Niantic Lightship license key](https://lightship.dev/docs/authentication.html) in the ARDK Auth Config object inside `Resources\ARDK\ArdkAuthConfig.asset`.
* [Build and run the AR application](https://docs.echo3D.co/unity/adding-ar-capabilities#4-build-and-run-the-ar-application).

## Common issues
* Make sure your system meets the [minimum requirments](https://lightship.dev/docs/system_reqs.html) for Niantic Lightship.
* If you are building for Android, make you you follow [these extra instructions](https://lightship.dev/docs/building_android.html) before building your app.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join).

## Screenshots
![Screenshot1](/Screenshots/screenshot.gif)
