# Hack Together: Microsoft Graph and .NET 🦒

This is a Microsoft Graph sample code forked from [Hackathon repo](https://github.com/microsoft/hack-together/tree/main/templates/dotnet-blazor-server-app-microsoft-graph).

![image](https://user-images.githubusercontent.com/43414651/225232638-7505a775-f267-4047-b853-e971c5f7a857.png)

#### 1.To retrieve personal info like: name, mobile number, job title, and etc
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


#### 2.To retrieve top 10 email messages and display their subjects

    foreach (var message in _messages)
    {
        <p>@message.Subject</p>
    }
    
### Reference
* [Explore Microsoft Graph scenarios for ASP.NET Core development](https://learn.microsoft.com/en-us/training/paths/m365-msgraph-dotnet-core-scenarios/)
* [.NET Core Razor Pages with Microsoft Graph](https://github.com/microsoftdocs/mslearn-m365-microsoftgraph-dotnetcorerazor)
* [Hack Together: Microsoft Graph and .NET ](https://github.com/microsoft/hack-together)

### Contributors
* [Ron Zhong](https://github.com/ron-zhong)
* [Su Su](https://github.com/mims-susu)
* [Mirza Ghulam Rasyid](https://github.com/mirzaevolution)
* [Marxis Cabero](https://github.com/mccabero)
