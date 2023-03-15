## Hack Together: Microsoft Graph and .NET 🦒

### Project name: Displaying personal info and send an email via Microsoft Graph 
### Description:

[[Try it out](https://blazor-graph.azurewebsites.net/)](https://blazor-graph.azurewebsites.net/)
![Untitled video - Made with Clipchamp (3)](https://user-images.githubusercontent.com/43414651/225307528-d8c9c486-09b1-440c-8d44-6ce7a84073c0.gif)

By participating **Hack Together: Microsoft Graph and .NET** hackathon as beginners, we downloaded the sample code from [here](https://github.com/microsoft/hack-together/tree/main/templates/dotnet-blazor-server-app-microsoft-graph)

We created a new app registration **Hackathon.Graph.Blazor** under our coporate POC Azure subscription and configured the post-login-return-url as below:
![image](https://user-images.githubusercontent.com/43414651/225235953-7e2139d9-cf92-4f0c-935a-b4d78af1e5f6.png)

We enriched the sample application by retrieving additional personal info and display first 10 email subjects via  Microsoft Graph .

#### 1. Display personal info like: name, mobile number, job title, and etc
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


#### 2. Displaying first 25 email messages

    <h4 class="text-primary">Top 25 Emails</h4>
    <div class="table-responsive">
        <table class="table table-hover table-borderless">
        <thead>
            <tr>
                <td>From</td>
                <td>Subject</td>
                <td>Received at</td>
            </tr>
        </thead>
        <tbody>
            @foreach (var message in _messages)
            {
                <tr>
                    <td class="text-primary text-decoration-underline">@(message.From.EmailAddress.Address)</td>
                    <td>@message.Subject</td>
                    <td class="text-nowrap">@(message.ReceivedDateTime.Value.ToLocalTime().ToString())</td>

                </tr>
            }
        </tbody>
    </table>
    </div>
    
![image](https://user-images.githubusercontent.com/43414651/225302745-c60abab1-a56c-4dd0-a0c2-be95115c6354.png)


#### 3. Send an email via Microsoft Graph

    var message = new Message
    {
        Subject = subject,
        Body = new ItemBody
        {
            Content = body,
            ContentType = BodyType.Text
        },
        ToRecipients = new Recipient[]
        {
            new Recipient
            {
                EmailAddress = new EmailAddress
                {
                    Address = to
                }
            }
        }
    };
    await _graphServiceClient.Me.SendMail(message).Request().PostAsync();
    
![image](https://user-images.githubusercontent.com/43414651/225301601-a1838fd1-979e-4d76-8940-80a3f4e5fdaa.png)   
   
### Reference
* [Explore Microsoft Graph scenarios for ASP.NET Core development](https://learn.microsoft.com/en-us/training/paths/m365-msgraph-dotnet-core-scenarios/)
* [.NET Core Razor Pages with Microsoft Graph](https://github.com/microsoftdocs/mslearn-m365-microsoftgraph-dotnetcorerazor)
* [Hack Together: Microsoft Graph and .NET ](https://github.com/microsoft/hack-together)

### Contributors
* [Ron Zhong](https://github.com/ron-zhong)
* [Su Su](https://github.com/mims-susu)
* [Mirza Ghulam Rasyid](https://github.com/mirzaevolution)
* [Marxis Cabero](https://github.com/mccabero)
