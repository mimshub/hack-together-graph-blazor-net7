## Hack Together: Microsoft Graph and .NET 🦒

### Project name: Displaying personal info and email subjects via Microsoft Graph 
### Description:

**Here is the outcome:**
[Try it out](https://blazor-graph.azurewebsites.net/)
![image](https://user-images.githubusercontent.com/43414651/225232638-7505a775-f267-4047-b853-e971c5f7a857.png)

By participating **Hack Together: Microsoft Graph and .NET** hackathon as beginners, we downloaded the sample code from [here](https://github.com/microsoft/hack-together/tree/main/templates/dotnet-blazor-server-app-microsoft-graph)

We created a new app registration **Hackathon.Graph.Blazor** under our coporate POC Azure subscription and configured the post-login-return-url as below:
![image](https://user-images.githubusercontent.com/43414651/225235953-7e2139d9-cf92-4f0c-935a-b4d78af1e5f6.png)

We enriched the sample application by retrieving additional personal info and display first 10 email subjects via  Microsoft Graph .

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
    
![image](https://user-images.githubusercontent.com/43414651/225238304-d75b559d-2100-4c16-9b11-30d53c642421.png)

By requesting additional scopes "presence.read mailboxsettings.read mail.read calendars.read files.readwrite", it requires users' consent.
![image](https://user-images.githubusercontent.com/43414651/225240599-17f2e0d3-f0de-47be-81b1-1798c6ffecb5.png)
   
   
### Reference
* [Explore Microsoft Graph scenarios for ASP.NET Core development](https://learn.microsoft.com/en-us/training/paths/m365-msgraph-dotnet-core-scenarios/)
* [.NET Core Razor Pages with Microsoft Graph](https://github.com/microsoftdocs/mslearn-m365-microsoftgraph-dotnetcorerazor)
* [Hack Together: Microsoft Graph and .NET ](https://github.com/microsoft/hack-together)

### Contributors
* [Ron Zhong](https://github.com/ron-zhong)
* [Su Su](https://github.com/mims-susu)
* [Mirza Ghulam Rasyid](https://github.com/mirzaevolution)
* [Marxis Cabero](https://github.com/mccabero)
