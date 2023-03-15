using BlazorSample.Graph;
using BlazorSample.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Identity.Web;

namespace BlazorSample.Pages
{
    public partial class SendEmail
    {
        [Inject]
        private MicrosoftIdentityConsentAndConditionalAccessHandler _consentHandler { get; set; }

        [Inject]
        private GraphEmailClient _graphEmailClient { get; set; }

        [Inject] GraphProfileClient _graphProfileClient { get; set; }

        public SendEmailModel SendEmailModel { get; set; }
        public string CurrentUser { get; set; }
        public bool IsSubmitted { get; set; }
        public string ErrorMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                SendEmailModel = new SendEmailModel();
                var user = await _graphProfileClient.GetUserProfile();
                if (user != null)
                {
                    CurrentUser = user.DisplayName;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                _consentHandler.HandleException(ex);

            }
        }

        protected void Reset()
        {
            SendEmailModel.ToAddress = string.Empty;
            SendEmailModel.Subject = string.Empty;
            SendEmailModel.Body = string.Empty;
            IsSubmitted = false;
            ErrorMessage = string.Empty;
        }

        protected async Task Send()
        {
            IsSubmitted = true;

            try
            {
                await _graphEmailClient
                    .SendEmailAsync(
                       to: SendEmailModel.ToAddress,
                       subject: SendEmailModel.Subject,
                       body: SendEmailModel.Body);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                _consentHandler.HandleException(ex);

            }
        }
    }
}
