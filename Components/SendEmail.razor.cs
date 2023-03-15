using BlazorSample.Graph;
using BlazorSample.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Identity.Web;

namespace BlazorSample.Components
{
    public partial class SendEmail
    {
        [Inject]
        private MicrosoftIdentityConsentAndConditionalAccessHandler _consentHandler { get; set; }

        [Inject]
        private GraphEmailClient _graphEmailClient { get; set; }

        [Inject]
        private NavigationManager _navigationManager { get; set; }

        public SendEmailModel SendEmailModel { get; set; }
        public bool IsSubmitted { get; set; }
        public string ErrorMessage { get; set; }

        protected override void OnInitialized()
        {
            SendEmailModel = new SendEmailModel();
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

        protected void NavigateBackToEmailList()
        {
            _navigationManager.NavigateTo("/emails");

        }
    }
}
