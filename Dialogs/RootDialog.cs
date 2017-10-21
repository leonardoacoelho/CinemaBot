using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using CinemaBot.Answer;

namespace CinemaBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;

            var text = activity.Text ?? string.Empty;

            if (!string.IsNullOrEmpty(text))
                await context.PostAsync(AnswerLogic.GetAnswer(text));

            context.Wait(MessageReceivedAsync);
        }
    }
}