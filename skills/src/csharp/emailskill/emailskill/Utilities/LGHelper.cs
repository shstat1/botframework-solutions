﻿using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.LanguageGeneration;
using Microsoft.Bot.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using Microsoft.Bot.Builder.Dialogs.Adaptive.Templates;

namespace EmailSkill.Utilities
{
    public class LGHelper
    {
        public static async Task<IMessageActivity> GenerateMessageAsync(
            ITurnContext turnContext,
            string replyTemp,
            object replyArg)
        {
            string templateName = "@{" + replyTemp + "()}";
            return await new ActivityTemplate(templateName).BindToData(turnContext, replyArg);

            //var result = await lgMultiLangEngine.Generate(turnContext, replyTemp, replyArg);
            //var activity = await new TextMessageActivityGenerator().CreateActivityFromText(turnContext, result, null);

            //return activity;
        }

        //public static async Task<IMessageActivity> GenerateAdaptiveCardAsync(
        //    ITurnContext turnContext,
        //    string replyTemp,
        //    object replyArg,
        //    string cardTemp,
        //    object cardArg)
        //{


        //    var replyText = await lgMultiLangEngine.Generate(turnContext, replyTemp, replyArg);
        //    var replyCard = await new TextMessageActivityGenerator().CreateActivityFromText(turnContext, replyText, null);

        //    var cardContent = await lgMultiLangEngine.Generate(turnContext, cardTemp, cardArg);
        //    var reply = new Attachment()
        //    {
        //        ContentType = "application/vnd.microsoft.card.adaptive",
        //        Content = JsonConvert.DeserializeObject(cardContent)
        //    };

        //    replyCard.Attachments.Add(reply);
        //    return replyCard;
        //}

        //public static async Task<Activity> GetToDoResponseActivity(string templateName, ITurnContext turnContext, object data)
        //{
        //    string formatTemplateName = "@{" + templateName + "()}";
        //    return await new ActivityTemplate(formatTemplateName).BindToData(turnContext, data);
        //}
    }
}
