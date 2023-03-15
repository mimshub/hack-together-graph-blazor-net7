# Hack Together: Microsoft Graph and .NET 🦒

This is a template for a Blazor app built using .NET v7.0 that connects to Microsoft Graph forked from Hackathon repo. https://github.com/microsoft/hack-together/tree/main/templates/dotnet-blazor-server-app-microsoft-graph

![image](https://user-images.githubusercontent.com/43414651/225232638-7505a775-f267-4047-b853-e971c5f7a857.png)

#### 1.To retrieve personal info like: name, mobile number, job title...via Graph API
    <table class="table table-striped table-condensed" style="font-family: monospace">
        <tr>
            <th>Property</th>
            <th>Value</th>
        </tr>
        <tr>
            <td>Name</td>
            <td>@_user.DisplayName</td>
        </tr>
        <tr>
            <td>Mail</td>
            <td>@_user.Mail</td>
        </tr>
        <tr>
            <td>MobilePhone</td>
            <td>@_user.MobilePhone</td>
        </tr>
        <tr>
            <td>OfficeLocation</td>
            <td>@_user.OfficeLocation</td>
        </tr>
        <tr>
            <td>JobTitle</td>
            <td>@_user.JobTitle</td>
        </tr>
    </table>


#### 2.To retrieve top 10 email messages via Graph API

    foreach (var message in _messages)
    {
        <p>@message.Subject</p>
    }
    
## Reference

* [Tutorial: Create a Blazor Server app that uses the Microsoft identity platform for authentication](https://learn.microsoft.com/azure/active-directory/develop/tutorial-blazor-server)
* [Quickstart: Register an application with the Microsoft identity platform](https://learn.microsoft.com/azure/active-directory/develop/quickstart-register-app)
